
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages
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
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages.Read => "read",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages.Read,
                "write" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsPages.Write,
                _ => null,
            };
        }
    }
}