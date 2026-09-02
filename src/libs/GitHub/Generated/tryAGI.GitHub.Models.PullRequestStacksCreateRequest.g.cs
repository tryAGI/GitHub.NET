
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStacksCreateRequest
    {
        /// <summary>
        /// An ordered list of pull request numbers forming the stack from bottom to top.
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
        /// Initializes a new instance of the <see cref="PullRequestStacksCreateRequest" /> class.
        /// </summary>
        /// <param name="pullRequests">
        /// An ordered list of pull request numbers forming the stack from bottom to top.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStacksCreateRequest(
            global::System.Collections.Generic.IList<int> pullRequests)
        {
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStacksCreateRequest" /> class.
        /// </summary>
        public PullRequestStacksCreateRequest()
        {
        }

    }
}