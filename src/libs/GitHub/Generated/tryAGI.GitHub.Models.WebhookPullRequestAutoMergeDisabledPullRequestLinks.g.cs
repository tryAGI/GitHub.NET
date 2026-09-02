
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookPullRequestAutoMergeDisabledPullRequestLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksComments Comments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksCommits Commits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksHtml Html { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksIssue Issue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComment ReviewComment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComments ReviewComments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksSelf Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksStatuses Statuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeDisabledPullRequestLinks" /> class.
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
        public WebhookPullRequestAutoMergeDisabledPullRequestLinks(
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksComments comments,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksCommits commits,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksHtml html,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksIssue issue,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComment reviewComment,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksReviewComments reviewComments,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksSelf self,
            global::tryAGI.GitHub.WebhookPullRequestAutoMergeDisabledPullRequestLinksStatuses statuses)
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
        /// Initializes a new instance of the <see cref="WebhookPullRequestAutoMergeDisabledPullRequestLinks" /> class.
        /// </summary>
        public WebhookPullRequestAutoMergeDisabledPullRequestLinks()
        {
        }

    }
}