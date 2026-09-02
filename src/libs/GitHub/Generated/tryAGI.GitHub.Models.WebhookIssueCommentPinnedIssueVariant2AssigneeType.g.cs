
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueVariant2AssigneeType
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
    public static class WebhookIssueCommentPinnedIssueVariant2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueVariant2AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueVariant2AssigneeType.Bot => "Bot",
                WebhookIssueCommentPinnedIssueVariant2AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentPinnedIssueVariant2AssigneeType.Organization => "Organization",
                WebhookIssueCommentPinnedIssueVariant2AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueVariant2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentPinnedIssueVariant2AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentPinnedIssueVariant2AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentPinnedIssueVariant2AssigneeType.Organization,
                "User" => WebhookIssueCommentPinnedIssueVariant2AssigneeType.User,
                _ => null,
            };
        }
    }
}