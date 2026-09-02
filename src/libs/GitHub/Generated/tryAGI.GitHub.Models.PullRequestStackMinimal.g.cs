
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStackMinimal
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestStackMinimalBase Base { get; set; }

        /// <summary>
        /// Whether the stack has any open pull request. False when all pull requests are merged or closed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Open { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.PullRequestStackMinimalPullRequest> PullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackMinimal" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="base"></param>
        /// <param name="open">
        /// Whether the stack has any open pull request. False when all pull requests are merged or closed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="pullRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStackMinimal(
            int id,
            int number,
            string nodeId,
            string url,
            global::tryAGI.GitHub.PullRequestStackMinimalBase @base,
            bool open,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.PullRequestStackMinimalPullRequest> pullRequests)
        {
            this.Id = id;
            this.Number = number;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Open = open;
            this.CreatedAt = createdAt;
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStackMinimal" /> class.
        /// </summary>
        public PullRequestStackMinimal()
        {
        }

    }
}