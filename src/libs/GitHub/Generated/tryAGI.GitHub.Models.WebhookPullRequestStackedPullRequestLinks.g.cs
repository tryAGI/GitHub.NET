
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookPullRequestStackedPullRequestLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksComments Comments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksCommits Commits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksHtml Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksIssue Issue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksReviewComment ReviewComment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksReviewComments ReviewComments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksSelf Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksStatuses Statuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestStackedPullRequestLinks" /> class.
        /// </summary>
        /// <param name="comments"></param>
        /// <param name="commits"></param>
        /// <param name="html"></param>
        /// <param name="issue"></param>
        /// <param name="reviewComment"></param>
        /// <param name="reviewComments"></param>
        /// <param name="self"></param>
        /// <param name="statuses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestStackedPullRequestLinks(
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksComments comments,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksCommits commits,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksHtml html,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksIssue issue,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksReviewComment reviewComment,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksReviewComments reviewComments,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksSelf self,
            global::tryAGI.GitHub.WebhookPullRequestStackedPullRequestLinksStatuses statuses)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.ReviewComment = reviewComment ?? throw new global::System.ArgumentNullException(nameof(reviewComment));
            this.ReviewComments = reviewComments ?? throw new global::System.ArgumentNullException(nameof(reviewComments));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestStackedPullRequestLinks" /> class.
        /// </summary>
        public WebhookPullRequestStackedPullRequestLinks()
        {
        }

    }
}