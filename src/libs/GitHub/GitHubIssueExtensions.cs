namespace tryAGI.GitHub;

/// <summary>
/// Creates request-scoped GitHub REST options without mutating a shared generated client.
/// </summary>
public static class GitHubRequestOptions
{
    /// <summary>
    /// Creates GitHub REST headers for a bearer, OAuth, or installation token.
    /// </summary>
    public static AutoSDKRequestOptions CreateAuthenticated(
        string accessToken,
        string scheme = "Bearer",
        AutoSDKRequestOptions? requestOptions = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(accessToken);
        ArgumentException.ThrowIfNullOrWhiteSpace(scheme);

        requestOptions ??= new AutoSDKRequestOptions();
        requestOptions.Headers["Authorization"] = $"{scheme.Trim()} {accessToken.Trim()}";
        requestOptions.Headers["Accept"] = "application/vnd.github+json";
        requestOptions.Headers["X-GitHub-Api-Version"] = "2022-11-28";
        return requestOptions;
    }
}

/// <summary>
/// Result of a complete conditional repository-issue read.
/// </summary>
public sealed record GitHubIssueSnapshot(
    bool NotModified,
    string? EntityTag,
    IReadOnlyList<Issue> Issues);

/// <summary>
/// GitHub-specific issue workflows built on the generated REST surface.
/// </summary>
public static class GitHubIssueExtensions
{
    /// <summary>
    /// Reads all repository issues with first-page ETag validation. Pull requests returned by the
    /// GitHub issue endpoint are excluded.
    /// </summary>
    public static async Task<GitHubIssueSnapshot> ListRepositoryIssuesConditionalAsync(
        this IIssuesClient client,
        string owner,
        string repository,
        string? entityTag = null,
        int perPage = 100,
        int maxPages = 100,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(owner);
        ArgumentException.ThrowIfNullOrWhiteSpace(repository);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(perPage);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxPages);

        var firstPage = await AutoSDKConditionalRequests.SendAsync<IList<Issue>>(
            (requestOptions, token) => client.IssuesListForRepoAsResponseAsync(
                owner,
                repository,
                state: IssuesListForRepoState.All,
                sort: IssuesListForRepoSort.Updated,
                direction: IssuesListForRepoDirection.Desc,
                perPage: perPage,
                page: 1,
                requestOptions: requestOptions,
                cancellationToken: token),
            entityTag,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        if (firstPage.NotModified)
        {
            return new GitHubIssueSnapshot(true, firstPage.EntityTag ?? entityTag, []);
        }

        var firstItems = firstPage.Response?.Body ?? [];
        var issues = new List<Issue>(firstItems.Count);
        AddIssuesWithoutPullRequests(issues, firstItems);
        if (firstItems.Count < perPage)
        {
            return new GitHubIssueSnapshot(false, firstPage.EntityTag, issues);
        }

        for (var page = 2; page <= maxPages; page++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var items = await client.IssuesListForRepoAsync(
                owner,
                repository,
                state: IssuesListForRepoState.All,
                sort: IssuesListForRepoSort.Updated,
                direction: IssuesListForRepoDirection.Desc,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            AddIssuesWithoutPullRequests(issues, items);
            if (items.Count < perPage)
            {
                return new GitHubIssueSnapshot(false, firstPage.EntityTag, issues);
            }
        }

        throw new InvalidOperationException(
            $"GitHub issue pagination exceeded {maxPages * perPage} records for {owner}/{repository}.");
    }

    /// <summary>
    /// Finds repository issues whose body contains an exact marker. The scan is bounded and skips
    /// pull requests exposed by GitHub's shared issues endpoint.
    /// </summary>
    public static async Task<IReadOnlyList<Issue>> FindIssuesByMarkerAsync(
        this IIssuesClient client,
        string owner,
        string repository,
        string marker,
        int perPage = 100,
        int maxPages = 5,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(owner);
        ArgumentException.ThrowIfNullOrWhiteSpace(repository);
        ArgumentException.ThrowIfNullOrWhiteSpace(marker);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(perPage);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxPages);

        var matches = new List<Issue>();
        await foreach (var issue in AutoSDKPager.OffsetAsync<IList<Issue>, Issue>(
            async (page, token) => page > maxPages
                ? []
                : await client.IssuesListForRepoAsync(
                    owner,
                    repository,
                    state: IssuesListForRepoState.All,
                    sort: IssuesListForRepoSort.Updated,
                    direction: IssuesListForRepoDirection.Desc,
                    perPage: perPage,
                    page: page,
                    cancellationToken: token).ConfigureAwait(false),
            static page => page,
            page => page.Count >= perPage,
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (issue.PullRequest is null &&
                issue.Number > 0 &&
                issue.Body?.Contains(marker, StringComparison.Ordinal) == true)
            {
                matches.Add(issue);
            }
        }

        return matches;
    }

    /// <summary>
    /// Finds the first issue comment containing an exact marker using bounded pagination.
    /// </summary>
    public static async Task<IssueComment?> FindIssueCommentByMarkerAsync(
        this IIssuesClient client,
        string owner,
        string repository,
        int issueNumber,
        string marker,
        int perPage = 100,
        int maxPages = 10,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentException.ThrowIfNullOrWhiteSpace(owner);
        ArgumentException.ThrowIfNullOrWhiteSpace(repository);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(issueNumber);
        ArgumentException.ThrowIfNullOrWhiteSpace(marker);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(perPage);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maxPages);

        await foreach (var comment in AutoSDKPager.OffsetAsync<IList<IssueComment>, IssueComment>(
            async (page, token) => page > maxPages
                ? []
                : await client.IssuesListCommentsAsync(
                    owner,
                    repository,
                    issueNumber,
                    perPage: perPage,
                    page: page,
                    cancellationToken: token).ConfigureAwait(false),
            static page => page,
            page => page.Count >= perPage,
            cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            if (comment.Id > 0 &&
                comment.Body?.Contains(marker, StringComparison.Ordinal) == true)
            {
                return comment;
            }
        }

        return null;
    }

    private static void AddIssuesWithoutPullRequests(List<Issue> destination, IEnumerable<Issue> source)
    {
        destination.AddRange(source.Where(static issue => issue.PullRequest is null));
    }
}
