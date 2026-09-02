
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues
    {
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Read => "read",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Read,
                "write" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}