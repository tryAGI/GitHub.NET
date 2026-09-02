
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewCommentEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMinimal PullRequest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventComment Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="pullRequest"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewCommentEvent(
            string action,
            global::tryAGI.GitHub.PullRequestMinimal pullRequest,
            global::tryAGI.GitHub.PullRequestReviewCommentEventComment comment)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEvent" /> class.
        /// </summary>
        public PullRequestReviewCommentEvent()
        {
        }

    }
}