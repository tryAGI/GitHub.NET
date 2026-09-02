
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStackPullRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PullRequestStackPullRequestVariant2StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestStackPullRequestVariant2State State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        public global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackPullRequestVariant2" /> class.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="title"></param>
        /// <param name="state"></param>
        /// <param name="draft"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="mergedAt"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStackPullRequestVariant2(
            string nodeId,
            string title,
            global::tryAGI.GitHub.PullRequestStackPullRequestVariant2State state,
            bool draft,
            string htmlUrl,
            global::System.DateTime? mergedAt,
            global::tryAGI.GitHub.NullableSimpleUser? user)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.State = state;
            this.MergedAt = mergedAt;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackPullRequestVariant2" /> class.
        /// </summary>
        public PullRequestStackPullRequestVariant2()
        {
        }

    }
}