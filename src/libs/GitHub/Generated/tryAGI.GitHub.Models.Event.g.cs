
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Event
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Actor Actor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.EventRepo Repo { get; set; }

        /// <summary>
        /// Actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public global::tryAGI.GitHub.Actor? Org { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.CreateEvent, global::tryAGI.GitHub.DeleteEvent, global::tryAGI.GitHub.DiscussionEvent, global::tryAGI.GitHub.IssuesEvent, global::tryAGI.GitHub.IssueCommentEvent, global::tryAGI.GitHub.ForkEvent, global::tryAGI.GitHub.GollumEvent, global::tryAGI.GitHub.MemberEvent, global::tryAGI.GitHub.PublicEvent, global::tryAGI.GitHub.PushEvent, global::tryAGI.GitHub.PullRequestEvent, global::tryAGI.GitHub.PullRequestReviewCommentEvent, global::tryAGI.GitHub.PullRequestReviewEvent, global::tryAGI.GitHub.CommitCommentEvent, global::tryAGI.GitHub.ReleaseEvent, global::tryAGI.GitHub.WatchEvent>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CreateEvent, global::tryAGI.GitHub.DeleteEvent, global::tryAGI.GitHub.DiscussionEvent, global::tryAGI.GitHub.IssuesEvent, global::tryAGI.GitHub.IssueCommentEvent, global::tryAGI.GitHub.ForkEvent, global::tryAGI.GitHub.GollumEvent, global::tryAGI.GitHub.MemberEvent, global::tryAGI.GitHub.PublicEvent, global::tryAGI.GitHub.PushEvent, global::tryAGI.GitHub.PullRequestEvent, global::tryAGI.GitHub.PullRequestReviewCommentEvent, global::tryAGI.GitHub.PullRequestReviewEvent, global::tryAGI.GitHub.CommitCommentEvent, global::tryAGI.GitHub.ReleaseEvent, global::tryAGI.GitHub.WatchEvent> Payload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actor">
        /// Actor
        /// </param>
        /// <param name="repo"></param>
        /// <param name="payload"></param>
        /// <param name="public"></param>
        /// <param name="type"></param>
        /// <param name="org">
        /// Actor
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Event(
            string id,
            global::tryAGI.GitHub.Actor actor,
            global::tryAGI.GitHub.EventRepo repo,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CreateEvent, global::tryAGI.GitHub.DeleteEvent, global::tryAGI.GitHub.DiscussionEvent, global::tryAGI.GitHub.IssuesEvent, global::tryAGI.GitHub.IssueCommentEvent, global::tryAGI.GitHub.ForkEvent, global::tryAGI.GitHub.GollumEvent, global::tryAGI.GitHub.MemberEvent, global::tryAGI.GitHub.PublicEvent, global::tryAGI.GitHub.PushEvent, global::tryAGI.GitHub.PullRequestEvent, global::tryAGI.GitHub.PullRequestReviewCommentEvent, global::tryAGI.GitHub.PullRequestReviewEvent, global::tryAGI.GitHub.CommitCommentEvent, global::tryAGI.GitHub.ReleaseEvent, global::tryAGI.GitHub.WatchEvent> payload,
            bool @public,
            string? type,
            global::tryAGI.GitHub.Actor? org,
            global::System.DateTime? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Org = org;
            this.Payload = payload;
            this.Public = @public;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }

    }
}