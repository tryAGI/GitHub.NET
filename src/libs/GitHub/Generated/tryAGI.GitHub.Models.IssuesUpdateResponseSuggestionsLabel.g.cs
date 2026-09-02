
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestionsLabel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsLabelConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabelConfidence? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsLabelIgnoredReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabelIgnoredReason? IgnoredReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rationale"></param>
        /// <param name="suggest"></param>
        /// <param name="confidence"></param>
        /// <param name="ignored"></param>
        /// <param name="ignoredReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestionsLabel(
            string? name,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabelConfidence? confidence,
            bool? ignored,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabelIgnoredReason? ignoredReason)
        {
            this.Name = name;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
            this.Ignored = ignored;
            this.IgnoredReason = ignoredReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsLabel" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestionsLabel()
        {
        }

    }
}