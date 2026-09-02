
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects
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
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects.Read => "read",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects.Read,
                "write" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppPermissionsRepositoryProjects.Write,
                _ => null,
            };
        }
    }
}