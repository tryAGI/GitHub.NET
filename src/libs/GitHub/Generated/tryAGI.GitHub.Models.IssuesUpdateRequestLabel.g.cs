
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateRequestLabel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Optional reasoning for selecting this label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this label choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestLabelConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestLabelConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestLabel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="color"></param>
        /// <param name="rationale">
        /// Optional reasoning for selecting this label.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this label choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateRequestLabel(
            int? id,
            string? name,
            string? description,
            string? color,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateRequestLabelConfidence? confidence)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Color = color;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestLabel" /> class.
        /// </summary>
        public IssuesUpdateRequestLabel()
        {
        }

    }
}