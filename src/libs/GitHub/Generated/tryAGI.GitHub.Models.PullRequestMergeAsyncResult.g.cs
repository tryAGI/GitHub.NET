
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Pull Request Merge Async Result
    /// </summary>
    public sealed partial class PullRequestMergeAsyncResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullRequestMergeAsyncResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMergeAsyncResultStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant2, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant3>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant2, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant3> Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResult" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestMergeAsyncResult(
            global::tryAGI.GitHub.PullRequestMergeAsyncResultStatus status,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant1, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant2, global::tryAGI.GitHub.PullRequestMergeAsyncResultDetailsVariant3> details)
        {
            this.Status = status;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeAsyncResult" /> class.
        /// </summary>
        public PullRequestMergeAsyncResult()
        {
        }

    }
}