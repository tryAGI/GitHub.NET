
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The [comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment) itself.
    /// </summary>
    public sealed partial class WebhooksIssueComment
    {
        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssueCommentAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksIssueCommentAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// Contents of the issue comment
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
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the issue comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::tryAGI.GitHub.Integration? PerformedViaGithubApp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksIssueCommentReactions Reactions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URL for the issue comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.WebhooksIssueCommentUser? User { get; set; }

        /// <summary>
        /// Context around who pinned an issue comment and when it was pinned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pin")]
        public global::tryAGI.GitHub.NullablePinnedIssueComment? Pin { get; set; }

        /// <summary>
        /// Details about why an issue comment was minimized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimized")]
        public global::tryAGI.GitHub.NullableIssueCommentMinimized? Minimized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssueComment" /> class.
        /// </summary>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// Contents of the issue comment
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the issue comment
        /// </param>
        /// <param name="issueUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="reactions"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL for the issue comment
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="user"></param>
        /// <param name="pin">
        /// Context around who pinned an issue comment and when it was pinned.
        /// </param>
        /// <param name="minimized">
        /// Details about why an issue comment was minimized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksIssueComment(
            global::tryAGI.GitHub.WebhooksIssueCommentAuthorAssociation authorAssociation,
            string body,
            global::System.DateTime createdAt,
            string htmlUrl,
            long id,
            string issueUrl,
            string nodeId,
            global::tryAGI.GitHub.WebhooksIssueCommentReactions reactions,
            global::System.DateTime updatedAt,
            string url,
            global::tryAGI.GitHub.Integration? performedViaGithubApp,
            global::tryAGI.GitHub.WebhooksIssueCommentUser? user,
            global::tryAGI.GitHub.NullablePinnedIssueComment? pin,
            global::tryAGI.GitHub.NullableIssueCommentMinimized? minimized)
        {
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.IssueUrl = issueUrl ?? throw new global::System.ArgumentNullException(nameof(issueUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user;
            this.Pin = pin;
            this.Minimized = minimized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssueComment" /> class.
        /// </summary>
        public WebhooksIssueComment()
        {
        }

    }
}