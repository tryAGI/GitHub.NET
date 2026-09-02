
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The changes to the label if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookLabelEditedChanges
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public global::tryAGI.GitHub.WebhookLabelEditedChangesColor? Color { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::tryAGI.GitHub.WebhookLabelEditedChangesDescription? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::tryAGI.GitHub.WebhookLabelEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLabelEditedChanges(
            global::tryAGI.GitHub.WebhookLabelEditedChangesColor? color,
            global::tryAGI.GitHub.WebhookLabelEditedChangesDescription? description,
            global::tryAGI.GitHub.WebhookLabelEditedChangesName? name)
        {
            this.Color = color;
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        public WebhookLabelEditedChanges()
        {
        }

    }
}