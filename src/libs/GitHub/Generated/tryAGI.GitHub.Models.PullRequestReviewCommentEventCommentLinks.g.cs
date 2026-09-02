
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewCommentEventCommentLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksHtml Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksPullRequest PullRequest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksSelf Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEventCommentLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
        /// <param name="self"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewCommentEventCommentLinks(
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksHtml html,
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksPullRequest pullRequest,
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinksSelf self)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEventCommentLinks" /> class.
        /// </summary>
        public PullRequestReviewCommentEventCommentLinks()
        {
        }

    }
}