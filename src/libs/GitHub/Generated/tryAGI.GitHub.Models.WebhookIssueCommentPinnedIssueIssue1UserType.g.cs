
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1UserType
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
        /// <summary>
        ///
        /// </summary>
        Mannequin,
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
    public static class WebhookIssueCommentPinnedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentPinnedIssueIssue1UserType.Mannequin => "Mannequin",
                WebhookIssueCommentPinnedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentPinnedIssueIssue1UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentPinnedIssueIssue1UserType.Bot,
                "Mannequin" => WebhookIssueCommentPinnedIssueIssue1UserType.Mannequin,
                "Organization" => WebhookIssueCommentPinnedIssueIssue1UserType.Organization,
                "User" => WebhookIssueCommentPinnedIssueIssue1UserType.User,
                _ => null,
            };
        }
    }
}