
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesCreateRequestIssueFieldValue
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequestIssueFieldValue" /> class.
        /// </summary>
        /// <param name="fieldId">
        /// The ID of the issue field to set
        /// </param>
        /// <param name="value">
        /// The value to set for the field. For multi-select fields, provide an array of option names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesCreateRequestIssueFieldValue(
            int fieldId,
            global::tryAGI.GitHub.OneOf<string, double?, global::System.Collections.Generic.IList<string>> value)
        {
            this.FieldId = fieldId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequestIssueFieldValue" /> class.
        /// </summary>
        public IssuesCreateRequestIssueFieldValue()
        {
        }

    }
}