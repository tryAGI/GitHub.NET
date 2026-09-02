
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewEventReviewLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewEventReviewLinksHtml Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewEventReviewLinksPullRequest PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEventReviewLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewEventReviewLinks(
            global::tryAGI.GitHub.PullRequestReviewEventReviewLinksHtml html,
            global::tryAGI.GitHub.PullRequestReviewEventReviewLinksPullRequest pullRequest)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEventReviewLinks" /> class.
        /// </summary>
        public PullRequestReviewEventReviewLinks()
        {
        }

    }
}