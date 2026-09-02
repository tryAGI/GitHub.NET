
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewEventReview Review { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMinimal PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="review"></param>
        /// <param name="pullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewEvent(
            string action,
            global::tryAGI.GitHub.PullRequestReviewEventReview review,
            global::tryAGI.GitHub.PullRequestMinimal pullRequest)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Review = review ?? throw new global::System.ArgumentNullException(nameof(review));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEvent" /> class.
        /// </summary>
        public PullRequestReviewEvent()
        {
        }

    }
}