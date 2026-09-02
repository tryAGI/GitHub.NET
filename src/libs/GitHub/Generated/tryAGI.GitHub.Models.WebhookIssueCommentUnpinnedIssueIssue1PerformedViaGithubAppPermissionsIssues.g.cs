
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Read => "read",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Read,
                "write" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}