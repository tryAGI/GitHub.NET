
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReleaseEventRelease
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_short_description_html_truncated")]
        public bool? IsShortDescriptionHtmlTruncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description_html")]
        public string? ShortDescriptionHtml { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseEventRelease" /> class.
        /// </summary>
        /// <param name="isShortDescriptionHtmlTruncated"></param>
        /// <param name="shortDescriptionHtml"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReleaseEventRelease(
            bool? isShortDescriptionHtmlTruncated,
            string? shortDescriptionHtml)
        {
            this.IsShortDescriptionHtmlTruncated = isShortDescriptionHtmlTruncated;
            this.ShortDescriptionHtml = shortDescriptionHtml;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseEventRelease" /> class.
        /// </summary>
        public ReleaseEventRelease()
        {
        }

    }
}