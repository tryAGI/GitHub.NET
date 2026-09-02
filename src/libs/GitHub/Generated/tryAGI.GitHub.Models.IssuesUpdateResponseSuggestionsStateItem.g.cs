
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestionsStateItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        public string? StateReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicate_issue_id")]
        public int? DuplicateIssueId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsStateItemConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItemConfidence? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsStateItemIgnoredReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItemIgnoredReason? IgnoredReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsStateItem" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="stateReason"></param>
        /// <param name="duplicateIssueId"></param>
        /// <param name="rationale"></param>
        /// <param name="suggest"></param>
        /// <param name="confidence"></param>
        /// <param name="ignored"></param>
        /// <param name="ignoredReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestionsStateItem(
            string? value,
            string? stateReason,
            int? duplicateIssueId,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItemConfidence? confidence,
            bool? ignored,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItemIgnoredReason? ignoredReason)
        {
            this.Value = value;
            this.StateReason = stateReason;
            this.DuplicateIssueId = duplicateIssueId;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
            this.Ignored = ignored;
            this.IgnoredReason = ignoredReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsStateItem" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestionsStateItem()
        {
        }

    }
}