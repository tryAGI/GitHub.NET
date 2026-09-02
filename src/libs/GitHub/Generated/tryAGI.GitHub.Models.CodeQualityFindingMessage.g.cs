
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Code quality finding message
    /// </summary>
    public sealed partial class CodeQualityFindingMessage
    {
        /// <summary>
        /// The message text of the code quality finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The message text of the code quality finding in markdown format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingMessage" /> class.
        /// </summary>
        /// <param name="text">
        /// The message text of the code quality finding.
        /// </param>
        /// <param name="markdown">
        /// The message text of the code quality finding in markdown format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualityFindingMessage(
            string text,
            string markdown)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingMessage" /> class.
        /// </summary>
        public CodeQualityFindingMessage()
        {
        }

    }
}