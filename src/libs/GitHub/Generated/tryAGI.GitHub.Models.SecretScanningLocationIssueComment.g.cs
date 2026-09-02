
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Represents an 'issue_comment' secret scanning location type. This location type shows that a secret was detected in a comment on an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueComment
    {
        /// <summary>
        /// The API URL to get the issue comment where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments/1081119451
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/comments/1081119451</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueCommentUrl { get; set; }

        /// <summary>
        /// The GitHub URL for the issue comment where the secret was detected.<br/>
        /// Example: https://github.com/octocat/Hello-World/issues/1#issuecomment-1081119451
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/issues/1#issuecomment-1081119451</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueComment" /> class.
        /// </summary>
        /// <param name="issueCommentUrl">
        /// The API URL to get the issue comment where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/comments/1081119451
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL for the issue comment where the secret was detected.<br/>
        /// Example: https://github.com/octocat/Hello-World/issues/1#issuecomment-1081119451
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningLocationIssueComment(
            string issueCommentUrl,
            string? htmlUrl)
        {
            this.IssueCommentUrl = issueCommentUrl ?? throw new global::System.ArgumentNullException(nameof(issueCommentUrl));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueComment" /> class.
        /// </summary>
        public SecretScanningLocationIssueComment()
        {
        }

    }
}