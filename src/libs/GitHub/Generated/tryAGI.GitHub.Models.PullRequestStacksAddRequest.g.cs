
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStacksAddRequest
    {
        /// <summary>
        /// An ordered list of pull request numbers to append to the stack, from the current top upward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> PullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStacksAddRequest" /> class.
        /// </summary>
        /// <param name="pullRequests">
        /// An ordered list of pull request numbers to append to the stack, from the current top upward.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStacksAddRequest(
            global::System.Collections.Generic.IList<int> pullRequests)
        {
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStacksAddRequest" /> class.
        /// </summary>
        public PullRequestStacksAddRequest()
        {
        }

    }
}