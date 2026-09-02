
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The issue type with optional metadata.
    /// </summary>
    public sealed partial class IssuesUpdateRequestType
    {
        /// <summary>
        /// The name of the issue type to associate with this issue, or `null` to remove the current issue type.<br/>
        /// Example: Epic
        /// </summary>
        /// <example>Epic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Optional reasoning for selecting this type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this type choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestTypeConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestTypeConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestType" /> class.
        /// </summary>
        /// <param name="value">
        /// The name of the issue type to associate with this issue, or `null` to remove the current issue type.<br/>
        /// Example: Epic
        /// </param>
        /// <param name="rationale">
        /// Optional reasoning for selecting this type.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this type choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateRequestType(
            string? value,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateRequestTypeConfidence? confidence)
        {
            this.Value = value;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestType" /> class.
        /// </summary>
        public IssuesUpdateRequestType()
        {
        }

    }
}