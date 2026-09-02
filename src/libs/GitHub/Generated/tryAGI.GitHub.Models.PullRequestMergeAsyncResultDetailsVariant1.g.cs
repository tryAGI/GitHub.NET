
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// When an asynchronous merge request was created or already existed
    /// </summary>
    public sealed partial class PullRequestMergeAsyncResultDetailsVariant1
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
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullRequestMergeAsyncResultDetailsVariant1MergeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1MergeMethod MergeMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullRequestMergeAsyncResultDetailsVariant1MergeActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1MergeAction MergeAction { get; set; }

        /// <summary>
        /// SHA that the pull request head must match for the enqueued merge to proceed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpectedHeadSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResultDetailsVariant1" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="uuid"></param>
        /// <param name="mergeMethod"></param>
        /// <param name="mergeAction"></param>
        /// <param name="expectedHeadSha">
        /// SHA that the pull request head must match for the enqueued merge to proceed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestMergeAsyncResultDetailsVariant1(
            string message,
            string uuid,
            global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1MergeMethod mergeMethod,
            global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1MergeAction mergeAction,
            string expectedHeadSha)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.MergeMethod = mergeMethod;
            this.MergeAction = mergeAction;
            this.ExpectedHeadSha = expectedHeadSha ?? throw new global::System.ArgumentNullException(nameof(expectedHeadSha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResultDetailsVariant1" /> class.
        /// </summary>
        public PullRequestMergeAsyncResultDetailsVariant1()
        {
        }

    }
}