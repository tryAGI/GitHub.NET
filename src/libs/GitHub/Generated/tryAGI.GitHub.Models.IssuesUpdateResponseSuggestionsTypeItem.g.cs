
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestionsTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsTypeItemConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItemConfidence? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsTypeItemIgnoredReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItemIgnoredReason? IgnoredReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsTypeItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rationale"></param>
        /// <param name="suggest"></param>
        /// <param name="confidence"></param>
        /// <param name="ignored"></param>
        /// <param name="ignoredReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestionsTypeItem(
            string? value,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItemConfidence? confidence,
            bool? ignored,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItemIgnoredReason? ignoredReason)
        {
            this.Value = value;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
            this.Ignored = ignored;
            this.IgnoredReason = ignoredReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsTypeItem" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestionsTypeItem()
        {
        }

    }
}