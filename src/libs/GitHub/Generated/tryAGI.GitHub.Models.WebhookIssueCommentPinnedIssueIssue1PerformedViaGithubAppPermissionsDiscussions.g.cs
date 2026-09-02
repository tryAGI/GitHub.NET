
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions
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
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions.Read => "read",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions.Read,
                "write" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsDiscussions.Write,
                _ => null,
            };
        }
    }
}