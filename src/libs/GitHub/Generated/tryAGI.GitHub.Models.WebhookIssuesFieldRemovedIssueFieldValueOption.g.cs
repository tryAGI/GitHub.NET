
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The selected option details. Present for single_select field types.
    /// </summary>
    public sealed partial class WebhookIssuesFieldRemovedIssueFieldValueOption
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
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemovedIssueFieldValueOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldRemovedIssueFieldValueOption(
            int? id,
            string? name,
            string? color,
            string? description)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemovedIssueFieldValueOption" /> class.
        /// </summary>
        public WebhookIssuesFieldRemovedIssueFieldValueOption()
        {
        }

    }
}