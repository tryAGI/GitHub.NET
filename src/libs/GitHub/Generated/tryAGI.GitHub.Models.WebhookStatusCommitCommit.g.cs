
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookStatusCommitCommit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AllOfJsonConverter<global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorCommitter, global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorCommitter, global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorVariant2> Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AllOfJsonConverter<global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterCommitter1, global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterCommitter1, global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterVariant2> Committer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookStatusCommitCommitTree Tree { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookStatusCommitCommitVerification Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="commentCount"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="url"></param>
        /// <param name="verification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStatusCommitCommit(
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorCommitter, global::tryAGI.GitHub.WebhookStatusCommitCommitAuthorVariant2> author,
            int commentCount,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterCommitter1, global::tryAGI.GitHub.WebhookStatusCommitCommitCommitterVariant2> committer,
            string message,
            global::tryAGI.GitHub.WebhookStatusCommitCommitTree tree,
            string url,
            global::tryAGI.GitHub.WebhookStatusCommitCommitVerification verification)
        {
            this.Author = author;
            this.CommentCount = commentCount;
            this.Committer = committer;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verification = verification ?? throw new global::System.ArgumentNullException(nameof(verification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        public WebhookStatusCommitCommit()
        {
        }

    }
}