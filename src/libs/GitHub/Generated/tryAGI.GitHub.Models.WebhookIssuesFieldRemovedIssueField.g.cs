
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The issue field whose value was cleared from the issue.
    /// </summary>
    public sealed partial class WebhookIssuesFieldRemovedIssueField
    {
        /// <summary>
        /// The unique identifier of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data type of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesFieldRemovedIssueFieldFieldTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueFieldFieldType FieldType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemovedIssueField" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue field.
        /// </param>
        /// <param name="name">
        /// The name of the issue field.
        /// </param>
        /// <param name="fieldType">
        /// The data type of the issue field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldRemovedIssueField(
            int id,
            string name,
            global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueFieldFieldType fieldType)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FieldType = fieldType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemovedIssueField" /> class.
        /// </summary>
        public WebhookIssuesFieldRemovedIssueField()
        {
        }

    }
}