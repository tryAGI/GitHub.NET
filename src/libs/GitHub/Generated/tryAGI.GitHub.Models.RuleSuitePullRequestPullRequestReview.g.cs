
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RuleSuitePullRequestPullRequestReview
    {
        /// <summary>
        /// The unique identifier of the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The user who submitted the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.RuleSuitePullRequestPullRequestReviewUser? User { get; set; }

        /// <summary>
        /// The state of the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequestReview" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the review.
        /// </param>
        /// <param name="user">
        /// The user who submitted the review.
        /// </param>
        /// <param name="state">
        /// The state of the review.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuitePullRequestPullRequestReview(
            int? id,
            global::tryAGI.GitHub.RuleSuitePullRequestPullRequestReviewUser? user,
            string? state)
        {
            this.Id = id;
            this.User = user;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequestReview" /> class.
        /// </summary>
        public RuleSuitePullRequestPullRequestReview()
        {
        }

    }
}