
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateRequestIssueFieldValue
    {
        /// <summary>
        /// The ID of the issue field to set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FieldId { get; set; }

        /// <summary>
        /// The value to set for the field. For multi-select fields, provide an array of option names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>> Value { get; set; }

        /// <summary>
        /// Optional reasoning for setting this field value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this field value choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestIssueFieldValueConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestIssueFieldValueConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestIssueFieldValue" /> class.
        /// </summary>
        /// <param name="fieldId">
        /// The ID of the issue field to set
        /// </param>
        /// <param name="value">
        /// The value to set for the field. For multi-select fields, provide an array of option names.
        /// </param>
        /// <param name="rationale">
        /// Optional reasoning for setting this field value.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this field value choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateRequestIssueFieldValue(
            int fieldId,
            global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>> value,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateRequestIssueFieldValueConfidence? confidence)
        {
            this.FieldId = fieldId;
            this.Value = value;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestIssueFieldValue" /> class.
        /// </summary>
        public IssuesUpdateRequestIssueFieldValue()
        {
        }

    }
}