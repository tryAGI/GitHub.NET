
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}