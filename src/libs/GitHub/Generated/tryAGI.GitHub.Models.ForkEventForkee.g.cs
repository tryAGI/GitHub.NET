
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ForkEventForkee
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::tryAGI.GitHub.SimpleUser? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fork")]
        public bool? Fork { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_url")]
        public string? ForksUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys_url")]
        public string? KeysUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators_url")]
        public string? CollaboratorsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        public string? TeamsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        public string? HooksUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_events_url")]
        public string? IssueEventsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees_url")]
        public string? AssigneesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branches_url")]
        public string? BranchesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_url")]
        public string? TagsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobs_url")]
        public string? BlobsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_tags_url")]
        public string? GitTagsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_refs_url")]
        public string? GitRefsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trees_url")]
        public string? TreesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses_url")]
        public string? StatusesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages_url")]
        public string? LanguagesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_url")]
        public string? StargazersUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors_url")]
        public string? ContributorsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers_url")]
        public string? SubscribersUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_url")]
        public string? SubscriptionUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits_url")]
        public string? CommitsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_commits_url")]
        public string? GitCommitsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        public string? CommentsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        public string? IssueCommentUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        public string? ContentsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compare_url")]
        public string? CompareUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merges_url")]
        public string? MergesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        public string? ArchiveUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloads_url")]
        public string? DownloadsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        public string? IssuesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulls_url")]
        public string? PullsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestones_url")]
        public string? MilestonesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications_url")]
        public string? NotificationsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        public string? LabelsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases_url")]
        public string? ReleasesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments_url")]
        public string? DeploymentsUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        public global::System.DateTime? PushedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_url")]
        public string? GitUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_url")]
        public string? SshUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_url")]
        public string? CloneUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svn_url")]
        public string? SvnUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stargazers_count")]
        public int? StargazersCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers_count")]
        public int? WatchersCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_issues")]
        public bool? HasIssues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_projects")]
        public bool? HasProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_downloads")]
        public bool? HasDownloads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_wiki")]
        public bool? HasWiki { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_pages")]
        public bool? HasPages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discussions")]
        public bool? HasDiscussions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_pull_requests")]
        public bool? HasPullRequests { get; set; }

        /// <summary>
        /// The policy controlling who can create pull requests: all or collaborators_only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_creation_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ForkEventForkeePullRequestCreationPolicyJsonConverter))]
        public global::tryAGI.GitHub.ForkEventForkeePullRequestCreationPolicy? PullRequestCreationPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks_count")]
        public int? ForksCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirror_url")]
        public string? MirrorUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues_count")]
        public int? OpenIssuesCount { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public global::tryAGI.GitHub.NullableLicenseSimple? License { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_forking")]
        public bool? AllowForking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forks")]
        public int? Forks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues")]
        public int? OpenIssues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watchers")]
        public int? Watchers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        public string? DefaultBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkEventForkee" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name"></param>
        /// <param name="fullName"></param>
        /// <param name="private"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="description"></param>
        /// <param name="fork"></param>
        /// <param name="url"></param>
        /// <param name="forksUrl"></param>
        /// <param name="keysUrl"></param>
        /// <param name="collaboratorsUrl"></param>
        /// <param name="teamsUrl"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="issueEventsUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="assigneesUrl"></param>
        /// <param name="branchesUrl"></param>
        /// <param name="tagsUrl"></param>
        /// <param name="blobsUrl"></param>
        /// <param name="gitTagsUrl"></param>
        /// <param name="gitRefsUrl"></param>
        /// <param name="treesUrl"></param>
        /// <param name="statusesUrl"></param>
        /// <param name="languagesUrl"></param>
        /// <param name="stargazersUrl"></param>
        /// <param name="contributorsUrl"></param>
        /// <param name="subscribersUrl"></param>
        /// <param name="subscriptionUrl"></param>
        /// <param name="commitsUrl"></param>
        /// <param name="gitCommitsUrl"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="issueCommentUrl"></param>
        /// <param name="contentsUrl"></param>
        /// <param name="compareUrl"></param>
        /// <param name="mergesUrl"></param>
        /// <param name="archiveUrl"></param>
        /// <param name="downloadsUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="pullsUrl"></param>
        /// <param name="milestonesUrl"></param>
        /// <param name="notificationsUrl"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="releasesUrl"></param>
        /// <param name="deploymentsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="pushedAt"></param>
        /// <param name="gitUrl"></param>
        /// <param name="sshUrl"></param>
        /// <param name="cloneUrl"></param>
        /// <param name="svnUrl"></param>
        /// <param name="homepage"></param>
        /// <param name="size"></param>
        /// <param name="stargazersCount"></param>
        /// <param name="watchersCount"></param>
        /// <param name="language"></param>
        /// <param name="hasIssues"></param>
        /// <param name="hasProjects"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="hasWiki"></param>
        /// <param name="hasPages"></param>
        /// <param name="hasDiscussions"></param>
        /// <param name="hasPullRequests"></param>
        /// <param name="pullRequestCreationPolicy">
        /// The policy controlling who can create pull requests: all or collaborators_only.
        /// </param>
        /// <param name="forksCount"></param>
        /// <param name="mirrorUrl"></param>
        /// <param name="archived"></param>
        /// <param name="disabled"></param>
        /// <param name="openIssuesCount"></param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="allowForking"></param>
        /// <param name="isTemplate"></param>
        /// <param name="webCommitSignoffRequired"></param>
        /// <param name="topics"></param>
        /// <param name="visibility"></param>
        /// <param name="forks"></param>
        /// <param name="openIssues"></param>
        /// <param name="watchers"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="public"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForkEventForkee(
            int? id,
            string? nodeId,
            string? name,
            string? fullName,
            bool? @private,
            global::tryAGI.GitHub.SimpleUser? owner,
            string? htmlUrl,
            string? description,
            bool? fork,
            string? url,
            string? forksUrl,
            string? keysUrl,
            string? collaboratorsUrl,
            string? teamsUrl,
            string? hooksUrl,
            string? issueEventsUrl,
            string? eventsUrl,
            string? assigneesUrl,
            string? branchesUrl,
            string? tagsUrl,
            string? blobsUrl,
            string? gitTagsUrl,
            string? gitRefsUrl,
            string? treesUrl,
            string? statusesUrl,
            string? languagesUrl,
            string? stargazersUrl,
            string? contributorsUrl,
            string? subscribersUrl,
            string? subscriptionUrl,
            string? commitsUrl,
            string? gitCommitsUrl,
            string? commentsUrl,
            string? issueCommentUrl,
            string? contentsUrl,
            string? compareUrl,
            string? mergesUrl,
            string? archiveUrl,
            string? downloadsUrl,
            string? issuesUrl,
            string? pullsUrl,
            string? milestonesUrl,
            string? notificationsUrl,
            string? labelsUrl,
            string? releasesUrl,
            string? deploymentsUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? pushedAt,
            string? gitUrl,
            string? sshUrl,
            string? cloneUrl,
            string? svnUrl,
            string? homepage,
            int? size,
            int? stargazersCount,
            int? watchersCount,
            string? language,
            bool? hasIssues,
            bool? hasProjects,
            bool? hasDownloads,
            bool? hasWiki,
            bool? hasPages,
            bool? hasDiscussions,
            bool? hasPullRequests,
            global::tryAGI.GitHub.ForkEventForkeePullRequestCreationPolicy? pullRequestCreationPolicy,
            int? forksCount,
            string? mirrorUrl,
            bool? archived,
            bool? disabled,
            int? openIssuesCount,
            global::tryAGI.GitHub.NullableLicenseSimple? license,
            bool? allowForking,
            bool? isTemplate,
            bool? webCommitSignoffRequired,
            global::System.Collections.Generic.IList<string>? topics,
            string? visibility,
            int? forks,
            int? openIssues,
            int? watchers,
            string? defaultBranch,
            bool? @public)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Name = name;
            this.FullName = fullName;
            this.Private = @private;
            this.Owner = owner;
            this.HtmlUrl = htmlUrl;
            this.Description = description;
            this.Fork = fork;
            this.Url = url;
            this.ForksUrl = forksUrl;
            this.KeysUrl = keysUrl;
            this.CollaboratorsUrl = collaboratorsUrl;
            this.TeamsUrl = teamsUrl;
            this.HooksUrl = hooksUrl;
            this.IssueEventsUrl = issueEventsUrl;
            this.EventsUrl = eventsUrl;
            this.AssigneesUrl = assigneesUrl;
            this.BranchesUrl = branchesUrl;
            this.TagsUrl = tagsUrl;
            this.BlobsUrl = blobsUrl;
            this.GitTagsUrl = gitTagsUrl;
            this.GitRefsUrl = gitRefsUrl;
            this.TreesUrl = treesUrl;
            this.StatusesUrl = statusesUrl;
            this.LanguagesUrl = languagesUrl;
            this.StargazersUrl = stargazersUrl;
            this.ContributorsUrl = contributorsUrl;
            this.SubscribersUrl = subscribersUrl;
            this.SubscriptionUrl = subscriptionUrl;
            this.CommitsUrl = commitsUrl;
            this.GitCommitsUrl = gitCommitsUrl;
            this.CommentsUrl = commentsUrl;
            this.IssueCommentUrl = issueCommentUrl;
            this.ContentsUrl = contentsUrl;
            this.CompareUrl = compareUrl;
            this.MergesUrl = mergesUrl;
            this.ArchiveUrl = archiveUrl;
            this.DownloadsUrl = downloadsUrl;
            this.IssuesUrl = issuesUrl;
            this.PullsUrl = pullsUrl;
            this.MilestonesUrl = milestonesUrl;
            this.NotificationsUrl = notificationsUrl;
            this.LabelsUrl = labelsUrl;
            this.ReleasesUrl = releasesUrl;
            this.DeploymentsUrl = deploymentsUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PushedAt = pushedAt;
            this.GitUrl = gitUrl;
            this.SshUrl = sshUrl;
            this.CloneUrl = cloneUrl;
            this.SvnUrl = svnUrl;
            this.Homepage = homepage;
            this.Size = size;
            this.StargazersCount = stargazersCount;
            this.WatchersCount = watchersCount;
            this.Language = language;
            this.HasIssues = hasIssues;
            this.HasProjects = hasProjects;
            this.HasDownloads = hasDownloads;
            this.HasWiki = hasWiki;
            this.HasPages = hasPages;
            this.HasDiscussions = hasDiscussions;
            this.HasPullRequests = hasPullRequests;
            this.PullRequestCreationPolicy = pullRequestCreationPolicy;
            this.ForksCount = forksCount;
            this.MirrorUrl = mirrorUrl;
            this.Archived = archived;
            this.Disabled = disabled;
            this.OpenIssuesCount = openIssuesCount;
            this.License = license;
            this.AllowForking = allowForking;
            this.IsTemplate = isTemplate;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
            this.Topics = topics;
            this.Visibility = visibility;
            this.Forks = forks;
            this.OpenIssues = openIssues;
            this.Watchers = watchers;
            this.DefaultBranch = defaultBranch;
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkEventForkee" /> class.
        /// </summary>
        public ForkEventForkee()
        {
        }

    }
}