
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners
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
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read => "read",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Read,
                "write" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.Write,
                _ => null,
            };
        }
    }
}