
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullsMergeAsyncRequest
    {
        /// <summary>
        /// Title for the automatic commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_title")]
        public string? CommitTitle { get; set; }

        /// <summary>
        /// Extra detail to append to automatic commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// SHA that pull request head must match to allow merge. If not provided, the current head of the PR at the time of the request will be used; if the PR is pushed in between the merge being requested and being executed, the merge will be cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullsMergeAsyncRequestMergeMethodJsonConverter))]
        public global::tryAGI.GitHub.PullsMergeAsyncRequestMergeMethod? MergeMethod { get; set; }

        /// <summary>
        /// The action that will be taken to merge the pull request. `direct_merge` merges the pull request directly without using a merge queue; `merge_queue` adds the pull request to a merge queue; `default` selects the most appropriate option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullsMergeAsyncRequestMergeActionJsonConverter))]
        public global::tryAGI.GitHub.PullsMergeAsyncRequestMergeAction? MergeAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsMergeAsyncRequest" /> class.
        /// </summary>
        /// <param name="commitTitle">
        /// Title for the automatic commit message.
        /// </param>
        /// <param name="commitMessage">
        /// Extra detail to append to automatic commit message.
        /// </param>
        /// <param name="sha">
        /// SHA that pull request head must match to allow merge. If not provided, the current head of the PR at the time of the request will be used; if the PR is pushed in between the merge being requested and being executed, the merge will be cancelled.
        /// </param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        /// <param name="mergeAction">
        /// The action that will be taken to merge the pull request. `direct_merge` merges the pull request directly without using a merge queue; `merge_queue` adds the pull request to a merge queue; `default` selects the most appropriate option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullsMergeAsyncRequest(
            string? commitTitle,
            string? commitMessage,
            string? sha,
            global::tryAGI.GitHub.PullsMergeAsyncRequestMergeMethod? mergeMethod,
            global::tryAGI.GitHub.PullsMergeAsyncRequestMergeAction? mergeAction)
        {
            this.CommitTitle = commitTitle;
            this.CommitMessage = commitMessage;
            this.Sha = sha;
            this.MergeMethod = mergeMethod;
            this.MergeAction = mergeAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsMergeAsyncRequest" /> class.
        /// </summary>
        public PullsMergeAsyncRequest()
        {
        }

    }
}