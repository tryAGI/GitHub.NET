
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewCommentLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentLinksSelf Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentLinksHtml Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentLinksPullRequest PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewCommentLinks(
            global::tryAGI.GitHub.PullRequestReviewCommentLinksSelf self,
            global::tryAGI.GitHub.PullRequestReviewCommentLinksHtml html,
            global::tryAGI.GitHub.PullRequestReviewCommentLinksPullRequest pullRequest)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinks" /> class.
        /// </summary>
        public PullRequestReviewCommentLinks()
        {
        }

    }
}