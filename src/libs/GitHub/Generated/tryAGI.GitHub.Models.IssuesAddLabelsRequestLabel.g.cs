
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesAddLabelsRequestLabel
    {
        /// <summary>
        /// The name of the label to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional reasoning for adding this label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the label is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this label choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesAddLabelsRequestLabelConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesAddLabelsRequestLabelConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestLabel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the label to add.
        /// </param>
        /// <param name="rationale">
        /// Optional reasoning for adding this label.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the label is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this label choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddLabelsRequestLabel(
            string name,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesAddLabelsRequestLabelConfidence? confidence)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestLabel" /> class.
        /// </summary>
        public IssuesAddLabelsRequestLabel()
        {
        }

    }
}