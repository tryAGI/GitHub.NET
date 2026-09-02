
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestionsIssueFieldValue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_id")]
        public int? FieldId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>))]
        public global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>>? Value { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsIssueFieldValueConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason? IgnoredReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsIssueFieldValue" /> class.
        /// </summary>
        /// <param name="fieldId"></param>
        /// <param name="value"></param>
        /// <param name="rationale"></param>
        /// <param name="suggest"></param>
        /// <param name="confidence"></param>
        /// <param name="ignored"></param>
        /// <param name="ignoredReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestionsIssueFieldValue(
            int? fieldId,
            global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>>? value,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueConfidence? confidence,
            bool? ignored,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason? ignoredReason)
        {
            this.FieldId = fieldId;
            this.Value = value;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
            this.Ignored = ignored;
            this.IgnoredReason = ignoredReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsIssueFieldValue" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestionsIssueFieldValue()
        {
        }

    }
}