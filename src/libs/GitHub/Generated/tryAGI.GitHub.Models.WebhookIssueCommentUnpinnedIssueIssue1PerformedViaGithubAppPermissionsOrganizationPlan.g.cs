
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan.Read => "read",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan.Read,
                "write" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationPlan.Write,
                _ => null,
            };
        }
    }
}