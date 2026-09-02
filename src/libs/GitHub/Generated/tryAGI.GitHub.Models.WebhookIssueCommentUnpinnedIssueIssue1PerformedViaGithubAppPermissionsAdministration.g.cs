
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}