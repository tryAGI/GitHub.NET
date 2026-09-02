
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningLocation
    {
        /// <summary>
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </summary>
        /// <example>commit</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningLocationTypeJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningLocationType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.SecretScanningLocationCommit, global::tryAGI.GitHub.SecretScanningLocationWikiCommit, global::tryAGI.GitHub.SecretScanningLocationIssueTitle, global::tryAGI.GitHub.SecretScanningLocationIssueBody, global::tryAGI.GitHub.SecretScanningLocationIssueComment, global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle, global::tryAGI.GitHub.SecretScanningLocationDiscussionBody, global::tryAGI.GitHub.SecretScanningLocationDiscussionComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle, global::tryAGI.GitHub.SecretScanningLocationPullRequestBody, global::tryAGI.GitHub.SecretScanningLocationPullRequestComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestReview, global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.SecretScanningLocationCommit, global::tryAGI.GitHub.SecretScanningLocationWikiCommit, global::tryAGI.GitHub.SecretScanningLocationIssueTitle, global::tryAGI.GitHub.SecretScanningLocationIssueBody, global::tryAGI.GitHub.SecretScanningLocationIssueComment, global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle, global::tryAGI.GitHub.SecretScanningLocationDiscussionBody, global::tryAGI.GitHub.SecretScanningLocationDiscussionComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle, global::tryAGI.GitHub.SecretScanningLocationPullRequestBody, global::tryAGI.GitHub.SecretScanningLocationPullRequestComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestReview, global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningLocation(
            global::tryAGI.GitHub.SecretScanningLocationType? type,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.SecretScanningLocationCommit, global::tryAGI.GitHub.SecretScanningLocationWikiCommit, global::tryAGI.GitHub.SecretScanningLocationIssueTitle, global::tryAGI.GitHub.SecretScanningLocationIssueBody, global::tryAGI.GitHub.SecretScanningLocationIssueComment, global::tryAGI.GitHub.SecretScanningLocationDiscussionTitle, global::tryAGI.GitHub.SecretScanningLocationDiscussionBody, global::tryAGI.GitHub.SecretScanningLocationDiscussionComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestTitle, global::tryAGI.GitHub.SecretScanningLocationPullRequestBody, global::tryAGI.GitHub.SecretScanningLocationPullRequestComment, global::tryAGI.GitHub.SecretScanningLocationPullRequestReview, global::tryAGI.GitHub.SecretScanningLocationPullRequestReviewComment>? details)
        {
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocation" /> class.
        /// </summary>
        public SecretScanningLocation()
        {
        }

    }
}