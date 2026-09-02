
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesAddIssueFieldValuesRequestIssueFieldValue
    {
        /// <summary>
        /// The ID of the issue field to set<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FieldId { get; set; }

        /// <summary>
        /// The value to set for the field. The type depends on the field's data type:<br/>
        /// - For text fields: provide a string value<br/>
        /// - For single_select fields: provide the option name as a string (must match an existing option)<br/>
        /// - For number fields: provide a numeric value<br/>
        /// - For multi_select fields: provide an array of option names (must match existing options)<br/>
        /// - For date fields: provide an ISO 8601 date string<br/>
        /// Example: Critical
        /// </summary>
        /// <example>Critical</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddIssueFieldValuesRequestIssueFieldValue" /> class.
        /// </summary>
        /// <param name="fieldId">
        /// The ID of the issue field to set<br/>
        /// Example: 123
        /// </param>
        /// <param name="value">
        /// The value to set for the field. The type depends on the field's data type:<br/>
        /// - For text fields: provide a string value<br/>
        /// - For single_select fields: provide the option name as a string (must match an existing option)<br/>
        /// - For number fields: provide a numeric value<br/>
        /// - For multi_select fields: provide an array of option names (must match existing options)<br/>
        /// - For date fields: provide an ISO 8601 date string<br/>
        /// Example: Critical
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddIssueFieldValuesRequestIssueFieldValue(
            int fieldId,
            global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>> value)
        {
            this.FieldId = fieldId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddIssueFieldValuesRequestIssueFieldValue" /> class.
        /// </summary>
        public IssuesAddIssueFieldValuesRequestIssueFieldValue()
        {
        }

    }
}