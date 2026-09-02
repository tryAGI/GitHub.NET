
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The value that was set or updated for the issue field. When updating an existing value, the previous value is available in `changes`.
    /// </summary>
    public sealed partial class WebhookIssuesFieldAddedIssueFieldValue
    {
        /// <summary>
        /// The unique identifier of the issue field value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The value of the field. Present for text, date, and number field types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AnyOfJsonConverter<string, double?, int?>))]
        public global::tryAGI.GitHub.AnyOf<string, double?, int?>? Value { get; set; }

        /// <summary>
        /// The identifier of the selected option. Present for single_select field types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_id")]
        public int? ValueId { get; set; }

        /// <summary>
        /// The selected option details. Present for single_select field types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("option")]
        public global::tryAGI.GitHub.WebhookIssuesFieldAddedIssueFieldValueOption? Option { get; set; }

        /// <summary>
        /// The identifiers of the selected options. Present for multi_select field types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_ids")]
        public global::System.Collections.Generic.IList<int>? ValueIds { get; set; }

        /// <summary>
        /// The selected option details. Present for multi_select field types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookIssuesFieldAddedIssueFieldValueOption2>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedIssueFieldValue" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue field value.
        /// </param>
        /// <param name="value">
        /// The value of the field. Present for text, date, and number field types.
        /// </param>
        /// <param name="valueId">
        /// The identifier of the selected option. Present for single_select field types.
        /// </param>
        /// <param name="option">
        /// The selected option details. Present for single_select field types.
        /// </param>
        /// <param name="valueIds">
        /// The identifiers of the selected options. Present for multi_select field types.
        /// </param>
        /// <param name="options">
        /// The selected option details. Present for multi_select field types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldAddedIssueFieldValue(
            int id,
            global::tryAGI.GitHub.AnyOf<string, double?, int?>? value,
            int? valueId,
            global::tryAGI.GitHub.WebhookIssuesFieldAddedIssueFieldValueOption? option,
            global::System.Collections.Generic.IList<int>? valueIds,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookIssuesFieldAddedIssueFieldValueOption2>? options)
        {
            this.Id = id;
            this.Value = value;
            this.ValueId = valueId;
            this.Option = option;
            this.ValueIds = valueIds;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedIssueFieldValue" /> class.
        /// </summary>
        public WebhookIssuesFieldAddedIssueFieldValue()
        {
        }

    }
}