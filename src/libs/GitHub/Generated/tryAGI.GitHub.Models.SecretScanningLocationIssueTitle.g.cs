
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Represents an 'issue_title' secret scanning location type. This location type shows that a secret was detected in the title of an issue.
    /// </summary>
    public sealed partial class SecretScanningLocationIssueTitle
    {
        /// <summary>
        /// The API URL to get the issue where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/issues/1347</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_title_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssueTitleUrl { get; set; }

        /// <summary>
        /// The GitHub URL for the issue where the secret was detected.<br/>
        /// Example: https://github.com/octocat/Hello-World/issues/1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/issues/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueTitle" /> class.
        /// </summary>
        /// <param name="issueTitleUrl">
        /// The API URL to get the issue where the secret was detected.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/issues/1347
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL for the issue where the secret was detected.<br/>
        /// Example: https://github.com/octocat/Hello-World/issues/1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningLocationIssueTitle(
            string issueTitleUrl,
            string? htmlUrl)
        {
            this.IssueTitleUrl = issueTitleUrl ?? throw new global::System.ArgumentNullException(nameof(issueTitleUrl));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationIssueTitle" /> class.
        /// </summary>
        public SecretScanningLocationIssueTitle()
        {
        }

    }
}