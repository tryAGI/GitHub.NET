
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewCommentLinks
    {
        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Link Self { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Link Html { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Link PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCommentLinks" /> class.
        /// </summary>
        /// <param name="self">
        /// Hypermedia Link
        /// </param>
        /// <param name="html">
        /// Hypermedia Link
        /// </param>
        /// <param name="pullRequest">
        /// Hypermedia Link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewCommentLinks(
            global::tryAGI.GitHub.Link self,
            global::tryAGI.GitHub.Link html,
            global::tryAGI.GitHub.Link pullRequest)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCommentLinks" /> class.
        /// </summary>
        public ReviewCommentLinks()
        {
        }

    }
}