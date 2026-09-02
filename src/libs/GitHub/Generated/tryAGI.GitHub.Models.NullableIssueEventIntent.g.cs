
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The intent behind an agent's action on an issue, including the rationale and confidence. Present (and `null` when the event carried no agent intent) on supported event types while the issue suggestions feature is enabled for the repository; the property is omitted entirely when the feature is disabled or the event type does not support intent.
    /// </summary>
    public sealed partial class NullableIssueEventIntent
    {
        /// <summary>
        /// The reasoning the agent provided for the change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// The confidence level the agent had when performing this action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.NullableIssueEventIntentConfidenceJsonConverter))]
        public global::tryAGI.GitHub.NullableIssueEventIntentConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueEventIntent" /> class.
        /// </summary>
        /// <param name="rationale">
        /// The reasoning the agent provided for the change.
        /// </param>
        /// <param name="confidence">
        /// The confidence level the agent had when performing this action.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableIssueEventIntent(
            string? rationale,
            global::tryAGI.GitHub.NullableIssueEventIntentConfidence? confidence)
        {
            this.Rationale = rationale;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueEventIntent" /> class.
        /// </summary>
        public NullableIssueEventIntent()
        {
        }

    }
}