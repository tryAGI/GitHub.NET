
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions.Read => "read",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions.Read,
                "write" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppPermissionsTeamDiscussions.Write,
                _ => null,
            };
        }
    }
}