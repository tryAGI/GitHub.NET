
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewCommentEventComment
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
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_id")]
        public int? PullRequestReviewId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_hunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffHunk { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OriginalPosition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        public string? SubjectType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.PullRequestReviewCommentEventCommentUser? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinks Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalCommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestReviewCommentEventCommentReactions Reactions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEventComment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="diffHunk"></param>
        /// <param name="path"></param>
        /// <param name="originalPosition"></param>
        /// <param name="commitId"></param>
        /// <param name="body"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="pullRequestUrl"></param>
        /// <param name="links"></param>
        /// <param name="originalCommitId"></param>
        /// <param name="reactions"></param>
        /// <param name="pullRequestReviewId"></param>
        /// <param name="position"></param>
        /// <param name="subjectType"></param>
        /// <param name="user"></param>
        /// <param name="inReplyToId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewCommentEventComment(
            int id,
            string nodeId,
            string url,
            string diffHunk,
            string path,
            int originalPosition,
            string commitId,
            string body,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string htmlUrl,
            string pullRequestUrl,
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentLinks links,
            string originalCommitId,
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentReactions reactions,
            int? pullRequestReviewId,
            int? position,
            string? subjectType,
            global::tryAGI.GitHub.PullRequestReviewCommentEventCommentUser? user,
            int? inReplyToId)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PullRequestReviewId = pullRequestReviewId;
            this.DiffHunk = diffHunk ?? throw new global::System.ArgumentNullException(nameof(diffHunk));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Position = position;
            this.OriginalPosition = originalPosition;
            this.SubjectType = subjectType;
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.User = user;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.OriginalCommitId = originalCommitId ?? throw new global::System.ArgumentNullException(nameof(originalCommitId));
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.InReplyToId = inReplyToId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentEventComment" /> class.
        /// </summary>
        public PullRequestReviewCommentEventComment()
        {
        }

    }
}