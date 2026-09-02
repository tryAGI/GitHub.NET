#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,

            global::tryAGI.GitHub.ReposUpdateReleaseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Release>> ReposUpdateReleaseAsResponseAsync(
            string owner,
            string repo,
            int releaseId,

            global::tryAGI.GitHub.ReposUpdateReleaseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a release<br/>
        /// Users with push access to the repository can edit a release.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If the resolved target commit (the new value of `target_commitish` if you are changing it, otherwise the existing target) adds or modifies any file under `.github/workflows/` relative to the repository's default branch, the authenticating token must be authorized to modify workflows. Otherwise, this endpoint returns `404 Not Found`; some authentication paths surface `403 Resource not accessible by integration` instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `workflow` scope when the resolved target commit modifies workflow files. Fine-grained access tokens and GitHub App installation tokens also need the "Workflows" repository permission (write). The `GITHUB_TOKEN` available to GitHub Actions cannot be authorized for this; for more information, see "[Automatic token authentication](https://docs.github.com/actions/security-guides/automatic-token-authentication#permissions-for-the-github_token)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="tagName">
        /// The name of the tag.
        /// </param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository's default branch.
        /// </param>
        /// <param name="name">
        /// The name of the release.
        /// </param>
        /// <param name="body">
        /// Text describing the contents of the tag.
        /// </param>
        /// <param name="draft">
        /// `true` makes the release a draft, and `false` publishes the release.
        /// </param>
        /// <param name="prerelease">
        /// `true` to identify the release as a prerelease, `false` to identify the release as a full release.
        /// </param>
        /// <param name="makeLatest">
        /// Specifies whether this release should be set as the latest release for the repository. Drafts and prereleases cannot be set as latest. Defaults to `true` for newly published releases. `legacy` specifies that the latest release should be determined based on the release creation date and higher semantic version.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="discussionCategoryName">
        /// If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. If there is already a discussion linked to the release, this parameter is ignored. For more information, see "[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository)."
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Release> ReposUpdateReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            string? tagName = default,
            string? targetCommitish = default,
            string? name = default,
            string? body = default,
            bool? draft = default,
            bool? prerelease = default,
            global::tryAGI.GitHub.ReposUpdateReleaseRequestMakeLatest? makeLatest = default,
            string? discussionCategoryName = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}