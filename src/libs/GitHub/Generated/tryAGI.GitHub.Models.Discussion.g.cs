
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A Discussion in a repository.
    /// </summary>
    public sealed partial class Discussion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_chosen_at")]
        public string? AnswerChosenAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_chosen_by")]
        public global::tryAGI.GitHub.DiscussionAnswerChosenBy? AnswerChosenBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer_html_url")]
        public string? AnswerHtmlUrl { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DiscussionAuthorAssociationJsonConverter))]
        public global::tryAGI.GitHub.DiscussionAuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.DiscussionCategory Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Comments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::tryAGI.GitHub.DiscussionReactions? Reactions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// The current state of the discussion.<br/>
        /// `converting` means that the discussion is being converted from an issue.<br/>
        /// `transferring` means that the discussion is being transferred from another repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DiscussionStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.DiscussionState State { get; set; }

        /// <summary>
        /// The reason for the current state<br/>
        /// Example: resolved
        /// </summary>
        /// <example>resolved</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DiscussionStateReasonJsonConverter))]
        public global::tryAGI.GitHub.DiscussionStateReason? StateReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.DiscussionUser? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussion" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="category"></param>
        /// <param name="comments"></param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="locked"></param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="state">
        /// The current state of the discussion.<br/>
        /// `converting` means that the discussion is being converted from an issue.<br/>
        /// `transferring` means that the discussion is being transferred from another repository.
        /// </param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
        /// <param name="activeLockReason"></param>
        /// <param name="answerChosenAt"></param>
        /// <param name="answerChosenBy"></param>
        /// <param name="answerHtmlUrl"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="reactions"></param>
        /// <param name="stateReason">
        /// The reason for the current state<br/>
        /// Example: resolved
        /// </param>
        /// <param name="timelineUrl"></param>
        /// <param name="user"></param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Discussion(
            string body,
            global::tryAGI.GitHub.DiscussionCategory category,
            int comments,
            global::System.DateTime createdAt,
            string htmlUrl,
            int id,
            bool locked,
            string nodeId,
            int number,
            string repositoryUrl,
            global::tryAGI.GitHub.DiscussionState state,
            string title,
            global::System.DateTime updatedAt,
            string? activeLockReason,
            string? answerChosenAt,
            global::tryAGI.GitHub.DiscussionAnswerChosenBy? answerChosenBy,
            string? answerHtmlUrl,
            global::tryAGI.GitHub.DiscussionAuthorAssociation? authorAssociation,
            global::tryAGI.GitHub.DiscussionReactions? reactions,
            global::tryAGI.GitHub.DiscussionStateReason? stateReason,
            string? timelineUrl,
            global::tryAGI.GitHub.DiscussionUser? user,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>? labels)
        {
            this.ActiveLockReason = activeLockReason;
            this.AnswerChosenAt = answerChosenAt;
            this.AnswerChosenBy = answerChosenBy;
            this.AnswerHtmlUrl = answerHtmlUrl;
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Comments = comments;
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Locked = locked;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.Reactions = reactions;
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.State = state;
            this.StateReason = stateReason;
            this.TimelineUrl = timelineUrl;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
            this.User = user;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discussion" /> class.
        /// </summary>
        public Discussion()
        {
        }

    }
}