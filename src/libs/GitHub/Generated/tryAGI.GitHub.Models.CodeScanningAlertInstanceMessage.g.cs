
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeScanningAlertInstanceMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The message text as GitHub-flavored Markdown, with placeholder links for related locations replaced by links to the relevant code. Only populated when related locations are available for the alert instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstanceMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="markdown">
        /// The message text as GitHub-flavored Markdown, with placeholder links for related locations replaced by links to the relevant code. Only populated when related locations are available for the alert instance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningAlertInstanceMessage(
            string? text,
            string? markdown)
        {
            this.Text = text;
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertInstanceMessage" /> class.
        /// </summary>
        public CodeScanningAlertInstanceMessage()
        {
        }

    }
}