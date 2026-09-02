
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}