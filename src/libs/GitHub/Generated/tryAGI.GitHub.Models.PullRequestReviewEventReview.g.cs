
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestReviewEventReview
    {
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
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.NullableSimpleUser? User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public string? SubmittedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        public string? PullRequestUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        public global::tryAGI.GitHub.PullRequestReviewEventReviewLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEventReview" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body"></param>
        /// <param name="commitId"></param>
        /// <param name="submittedAt"></param>
        /// <param name="state"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="pullRequestUrl"></param>
        /// <param name="links"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewEventReview(
            int? id,
            string? nodeId,
            global::tryAGI.GitHub.NullableSimpleUser? user,
            string? body,
            string? commitId,
            string? submittedAt,
            string? state,
            string? htmlUrl,
            string? pullRequestUrl,
            global::tryAGI.GitHub.PullRequestReviewEventReviewLinks? links,
            string? updatedAt)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.User = user;
            this.Body = body;
            this.CommitId = commitId;
            this.SubmittedAt = submittedAt;
            this.State = state;
            this.HtmlUrl = htmlUrl;
            this.PullRequestUrl = pullRequestUrl;
            this.Links = links;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewEventReview" /> class.
        /// </summary>
        public PullRequestReviewEventReview()
        {
        }

    }
}