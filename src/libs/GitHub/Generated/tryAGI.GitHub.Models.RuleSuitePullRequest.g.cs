
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Metadata for a pull request rule evaluation result.
    /// </summary>
    public sealed partial class RuleSuitePullRequest
    {
        /// <summary>
        /// The pull request associated with the rule evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        public global::tryAGI.GitHub.RuleSuitePullRequestPullRequest? PullRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequest" /> class.
        /// </summary>
        /// <param name="pullRequest">
        /// The pull request associated with the rule evaluation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuitePullRequest(
            global::tryAGI.GitHub.RuleSuitePullRequestPullRequest? pullRequest)
        {
            this.PullRequest = pullRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuitePullRequest" /> class.
        /// </summary>
        public RuleSuitePullRequest()
        {
        }

    }
}