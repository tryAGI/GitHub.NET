
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The user who submitted the review.
    /// </summary>
    public sealed partial class RuleSuitePullRequestPullRequestReviewUser
    {
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The handle for the GitHub user account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// The type of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequestReviewUser" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="login">
        /// The handle for the GitHub user account.
        /// </param>
        /// <param name="type">
        /// The type of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuitePullRequestPullRequestReviewUser(
            int? id,
            string? login,
            string? type)
        {
            this.Id = id;
            this.Login = login;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequestPullRequestReviewUser" /> class.
        /// </summary>
        public RuleSuitePullRequestPullRequestReviewUser()
        {
        }

    }
}