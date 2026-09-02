
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Parent-issue Removed Issue Event
    /// </summary>
    public sealed partial class ParentIssueRemovedIssueEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Actor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_url")]
        public string? CommitUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::tryAGI.GitHub.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue")]
        public global::tryAGI.GitHub.NullableIssueReference? ParentIssue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentIssueRemovedIssueEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="event"></param>
        /// <param name="createdAt"></param>
        /// <param name="commitId"></param>
        /// <param name="commitUrl"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="parentIssue">
        /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParentIssueRemovedIssueEvent(
            int id,
            string nodeId,
            string url,
            global::tryAGI.GitHub.SimpleUser actor,
            string @event,
            string createdAt,
            string? commitId,
            string? commitUrl,
            global::tryAGI.GitHub.NullableIntegration? performedViaGithubApp,
            global::tryAGI.GitHub.NullableIssueReference? parentIssue)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.CommitId = commitId;
            this.CommitUrl = commitUrl;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.ParentIssue = parentIssue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentIssueRemovedIssueEvent" /> class.
        /// </summary>
        public ParentIssueRemovedIssueEvent()
        {
        }

    }
}