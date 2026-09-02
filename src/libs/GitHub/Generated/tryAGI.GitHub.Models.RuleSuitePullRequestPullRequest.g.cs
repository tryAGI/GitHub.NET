
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The pull request associated with the rule evaluation.
    /// </summary>
    public sealed partial class RuleSuitePullRequestPullRequest
    {
        /// <summary>
        /// The unique identifier of the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The number of the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The user who created the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.RuleSuitePullRequestPullRequestUser? User { get; set; }

        /// <summary>
        /// The reviews associated with the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviews")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.RuleSuitePullRequestPullRequestReview>? Reviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the pull request.
        /// </param>
        /// <param name="number">
        /// The number of the pull request.
        /// </param>
        /// <param name="user">
        /// The user who created the pull request.
        /// </param>
        /// <param name="reviews">
        /// The reviews associated with the pull request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuitePullRequestPullRequest(
            int? id,
            int? number,
            global::tryAGI.GitHub.RuleSuitePullRequestPullRequestUser? user,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RuleSuitePullRequestPullRequestReview>? reviews)
        {
            this.Id = id;
            this.Number = number;
            this.User = user;
            this.Reviews = reviews;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequest" /> class.
        /// </summary>
        public RuleSuitePullRequestPullRequest()
        {
        }

    }
}