
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Issue Event
    /// </summary>
    public sealed partial class IssueEvent
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDEwOklzc3VlRXZlbnQx
        /// </summary>
        /// <example>MDEwOklzc3VlRXZlbnQx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/events/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::tryAGI.GitHub.NullableSimpleUser? Actor { get; set; }

        /// <summary>
        /// Example: closed
        /// </summary>
        /// <example>closed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_url")]
        public string? CommitUrl { get; set; }

        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        public global::tryAGI.GitHub.NullableIssue? Issue { get; set; }

        /// <summary>
        /// Issue Event Label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public global::tryAGI.GitHub.IssueEventLabel? Label { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::tryAGI.GitHub.NullableSimpleUser? Assignee { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigner")]
        public global::tryAGI.GitHub.NullableSimpleUser? Assigner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_requester")]
        public global::tryAGI.GitHub.NullableSimpleUser? ReviewRequester { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_reviewer")]
        public global::tryAGI.GitHub.NullableSimpleUser? RequestedReviewer { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_team")]
        public global::tryAGI.GitHub.Team? RequestedTeam { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_review")]
        public global::tryAGI.GitHub.IssueEventDismissedReview? DismissedReview { get; set; }

        /// <summary>
        /// Issue Event Milestone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        public global::tryAGI.GitHub.IssueEventMilestone? Milestone { get; set; }

        /// <summary>
        /// Issue Event Project Card
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_card")]
        public global::tryAGI.GitHub.IssueEventProjectCard? ProjectCard { get; set; }

        /// <summary>
        /// Issue Event Rename
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rename")]
        public global::tryAGI.GitHub.IssueEventRename? Rename { get; set; }

        /// <summary>
        /// The type of issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_type")]
        public global::tryAGI.GitHub.IssueTypeWebhook? IssueType { get; set; }

        /// <summary>
        /// The type of issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_issue_type")]
        public global::tryAGI.GitHub.IssueTypeWebhook? PrevIssueType { get; set; }

        /// <summary>
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue")]
        public global::tryAGI.GitHub.NullableIssueReference? SubIssue { get; set; }

        /// <summary>
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue")]
        public global::tryAGI.GitHub.NullableIssueReference? ParentIssue { get; set; }

        /// <summary>
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_by")]
        public global::tryAGI.GitHub.NullableIssueReference? BlockedBy { get; set; }

        /// <summary>
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        public global::tryAGI.GitHub.NullableIssueReference? Blocking { get; set; }

        /// <summary>
        /// The intent behind an agent's action on an issue, including the rationale and confidence. Present (and `null` when the event carried no agent intent) on supported event types while the issue suggestions feature is enabled for the repository; the property is omitted entirely when the feature is disabled or the event type does not support intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        public global::tryAGI.GitHub.NullableIssueEventIntent? Intent { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AuthorAssociationJsonConverter))]
        public global::tryAGI.GitHub.AuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_reason")]
        public string? LockReason { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::tryAGI.GitHub.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOklzc3VlRXZlbnQx
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/events/1
        /// </param>
        /// <param name="event">
        /// Example: closed
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="commitId">
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="commitUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/commits/6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="label">
        /// Issue Event Label
        /// </param>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="assigner">
        /// A GitHub user.
        /// </param>
        /// <param name="reviewRequester">
        /// A GitHub user.
        /// </param>
        /// <param name="requestedReviewer">
        /// A GitHub user.
        /// </param>
        /// <param name="requestedTeam">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
        /// <param name="dismissedReview"></param>
        /// <param name="milestone">
        /// Issue Event Milestone
        /// </param>
        /// <param name="projectCard">
        /// Issue Event Project Card
        /// </param>
        /// <param name="rename">
        /// Issue Event Rename
        /// </param>
        /// <param name="issueType">
        /// The type of issue.
        /// </param>
        /// <param name="prevIssueType">
        /// The type of issue.
        /// </param>
        /// <param name="subIssue">
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </param>
        /// <param name="parentIssue">
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </param>
        /// <param name="blockedBy">
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </param>
        /// <param name="blocking">
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </param>
        /// <param name="intent">
        /// The intent behind an agent's action on an issue, including the rationale and confidence. Present (and `null` when the event carried no agent intent) on supported event types while the issue suggestions feature is enabled for the repository; the property is omitted entirely when the feature is disabled or the event type does not support intent.
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="lockReason"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueEvent(
            long id,
            string nodeId,
            string url,
            string @event,
            global::System.DateTime createdAt,
            global::tryAGI.GitHub.NullableSimpleUser? actor,
            string? commitId,
            string? commitUrl,
            global::tryAGI.GitHub.NullableIssue? issue,
            global::tryAGI.GitHub.IssueEventLabel? label,
            global::tryAGI.GitHub.NullableSimpleUser? assignee,
            global::tryAGI.GitHub.NullableSimpleUser? assigner,
            global::tryAGI.GitHub.NullableSimpleUser? reviewRequester,
            global::tryAGI.GitHub.NullableSimpleUser? requestedReviewer,
            global::tryAGI.GitHub.Team? requestedTeam,
            global::tryAGI.GitHub.IssueEventDismissedReview? dismissedReview,
            global::tryAGI.GitHub.IssueEventMilestone? milestone,
            global::tryAGI.GitHub.IssueEventProjectCard? projectCard,
            global::tryAGI.GitHub.IssueEventRename? rename,
            global::tryAGI.GitHub.IssueTypeWebhook? issueType,
            global::tryAGI.GitHub.IssueTypeWebhook? prevIssueType,
            global::tryAGI.GitHub.NullableIssueReference? subIssue,
            global::tryAGI.GitHub.NullableIssueReference? parentIssue,
            global::tryAGI.GitHub.NullableIssueReference? blockedBy,
            global::tryAGI.GitHub.NullableIssueReference? blocking,
            global::tryAGI.GitHub.NullableIssueEventIntent? intent,
            global::tryAGI.GitHub.AuthorAssociation? authorAssociation,
            string? lockReason,
            global::tryAGI.GitHub.NullableIntegration? performedViaGithubApp)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Actor = actor;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.CommitId = commitId;
            this.CommitUrl = commitUrl;
            this.CreatedAt = createdAt;
            this.Issue = issue;
            this.Label = label;
            this.Assignee = assignee;
            this.Assigner = assigner;
            this.ReviewRequester = reviewRequester;
            this.RequestedReviewer = requestedReviewer;
            this.RequestedTeam = requestedTeam;
            this.DismissedReview = dismissedReview;
            this.Milestone = milestone;
            this.ProjectCard = projectCard;
            this.Rename = rename;
            this.IssueType = issueType;
            this.PrevIssueType = prevIssueType;
            this.SubIssue = subIssue;
            this.ParentIssue = parentIssue;
            this.BlockedBy = blockedBy;
            this.Blocking = blocking;
            this.Intent = intent;
            this.AuthorAssociation = authorAssociation;
            this.LockReason = lockReason;
            this.PerformedViaGithubApp = performedViaGithubApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEvent" /> class.
        /// </summary>
        public IssueEvent()
        {
        }

    }
}