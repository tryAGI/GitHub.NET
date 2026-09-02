
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommitCommentEventComment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.NullableSimpleUser? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::tryAGI.GitHub.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommentEventComment" /> class.
        /// </summary>
        /// <param name="htmlUrl"></param>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="body"></param>
        /// <param name="path"></param>
        /// <param name="position"></param>
        /// <param name="line"></param>
        /// <param name="commitId"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="reactions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitCommentEventComment(
            string? htmlUrl,
            string? url,
            int? id,
            string? nodeId,
            string? body,
            string? path,
            int? position,
            int? line,
            string? commitId,
            global::tryAGI.GitHub.NullableSimpleUser? user,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::tryAGI.GitHub.ReactionRollup? reactions)
        {
            this.HtmlUrl = htmlUrl;
            this.Url = url;
            this.Id = id;
            this.NodeId = nodeId;
            this.Body = body;
            this.Path = path;
            this.Position = position;
            this.Line = line;
            this.CommitId = commitId;
            this.User = user;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommentEventComment" /> class.
        /// </summary>
        public CommitCommentEventComment()
        {
        }

    }
}