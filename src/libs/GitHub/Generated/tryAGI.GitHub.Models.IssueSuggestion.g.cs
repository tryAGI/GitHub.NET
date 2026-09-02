
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// An agent-proposed change to an issue that a maintainer can approve or dismiss.
    /// </summary>
    public sealed partial class IssueSuggestion
    {
        /// <summary>
        /// The unique identifier of the suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The unique identifier of the issue the suggestion applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IssueId { get; set; }

        /// <summary>
        /// The kind of change proposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueSuggestionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.IssueSuggestionAction Action { get; set; }

        /// <summary>
        /// The suggestion's lifecycle state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueSuggestionStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.IssueSuggestionState State { get; set; }

        /// <summary>
        /// The identifier of the target the change applies to (issue type, label, field, assignee, or duplicate issue), when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_id")]
        public int? TargetId { get; set; }

        /// <summary>
        /// The proposed value, when applicable. An array for multi-select field suggestions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<string>>))]
        public global::tryAGI.GitHub.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<string>>? TargetValue { get; set; }

        /// <summary>
        /// The rationale the actor provided for the suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// The actor's confidence level in the suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueSuggestionConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssueSuggestionConfidence? Confidence { get; set; }

        /// <summary>
        /// The unique identifier of the actor that proposed the suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public int? ActorId { get; set; }

        /// <summary>
        /// The identifier of the timeline event created when the suggestion was approved, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_event_id")]
        public int? IssueEventId { get; set; }

        /// <summary>
        /// The unique identifier of the user who approved or dismissed the suggestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_by")]
        public int? ResolvedBy { get; set; }

        /// <summary>
        /// The time the suggestion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time the suggestion was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSuggestion" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the suggestion.
        /// </param>
        /// <param name="issueId">
        /// The unique identifier of the issue the suggestion applies to.
        /// </param>
        /// <param name="action">
        /// The kind of change proposed.
        /// </param>
        /// <param name="state">
        /// The suggestion's lifecycle state.
        /// </param>
        /// <param name="createdAt">
        /// The time the suggestion was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time the suggestion was last updated.
        /// </param>
        /// <param name="targetId">
        /// The identifier of the target the change applies to (issue type, label, field, assignee, or duplicate issue), when applicable.
        /// </param>
        /// <param name="targetValue">
        /// The proposed value, when applicable. An array for multi-select field suggestions.
        /// </param>
        /// <param name="rationale">
        /// The rationale the actor provided for the suggestion.
        /// </param>
        /// <param name="confidence">
        /// The actor's confidence level in the suggestion.
        /// </param>
        /// <param name="actorId">
        /// The unique identifier of the actor that proposed the suggestion.
        /// </param>
        /// <param name="issueEventId">
        /// The identifier of the timeline event created when the suggestion was approved, when applicable.
        /// </param>
        /// <param name="resolvedBy">
        /// The unique identifier of the user who approved or dismissed the suggestion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueSuggestion(
            int id,
            int issueId,
            global::tryAGI.GitHub.IssueSuggestionAction action,
            global::tryAGI.GitHub.IssueSuggestionState state,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? targetId,
            global::tryAGI.GitHub.OneOf<string, double?, bool?, global::System.Collections.Generic.IList<string>>? targetValue,
            string? rationale,
            global::tryAGI.GitHub.IssueSuggestionConfidence? confidence,
            int? actorId,
            int? issueEventId,
            int? resolvedBy)
        {
            this.Id = id;
            this.IssueId = issueId;
            this.Action = action;
            this.State = state;
            this.TargetId = targetId;
            this.TargetValue = targetValue;
            this.Rationale = rationale;
            this.Confidence = confidence;
            this.ActorId = actorId;
            this.IssueEventId = issueEventId;
            this.ResolvedBy = resolvedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSuggestion" /> class.
        /// </summary>
        public IssueSuggestion()
        {
        }

    }
}