
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of issue.
    /// </summary>
    public sealed partial class IssueTypeWebhook
    {
        /// <summary>
        /// The unique identifier of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The color of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueTypeWebhookColorJsonConverter))]
        public global::tryAGI.GitHub.IssueTypeWebhookColor? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTypeWebhook" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue type.
        /// </param>
        /// <param name="name">
        /// The name of the issue type.
        /// </param>
        /// <param name="color">
        /// The color of the issue type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueTypeWebhook(
            int id,
            string name,
            global::tryAGI.GitHub.IssueTypeWebhookColor? color)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTypeWebhook" /> class.
        /// </summary>
        public IssueTypeWebhook()
        {
        }

    }
}