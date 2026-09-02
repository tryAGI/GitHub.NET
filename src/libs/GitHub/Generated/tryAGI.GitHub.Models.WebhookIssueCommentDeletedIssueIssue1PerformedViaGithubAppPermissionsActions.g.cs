
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions
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
    public static class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions.Read => "read",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions.Read,
                "write" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsActions.Write,
                _ => null,
            };
        }
    }
}