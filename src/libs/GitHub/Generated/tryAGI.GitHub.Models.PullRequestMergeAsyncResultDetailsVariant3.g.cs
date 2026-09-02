
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// When the pull request is already merged
    /// </summary>
    public sealed partial class PullRequestMergeAsyncResultDetailsVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResultDetailsVariant3" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="sha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestMergeAsyncResultDetailsVariant3(
            string message,
            string sha)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResultDetailsVariant3" /> class.
        /// </summary>
        public PullRequestMergeAsyncResultDetailsVariant3()
        {
        }

    }
}