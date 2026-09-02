
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStackMinimalPullRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullRequestStackMinimalPullRequestStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestStackMinimalPullRequestState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        public global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestStackMinimalPullRequestHead Head { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackMinimalPullRequest" /> class.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="state"></param>
        /// <param name="draft"></param>
        /// <param name="head"></param>
        /// <param name="mergedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStackMinimalPullRequest(
            int number,
            global::tryAGI.GitHub.PullRequestStackMinimalPullRequestState state,
            bool draft,
            global::tryAGI.GitHub.PullRequestStackMinimalPullRequestHead head,
            global::System.DateTime? mergedAt)
        {
            this.Number = number;
            this.State = state;
            this.Draft = draft;
            this.MergedAt = mergedAt;
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackMinimalPullRequest" /> class.
        /// </summary>
        public PullRequestStackMinimalPullRequest()
        {
        }

    }
}