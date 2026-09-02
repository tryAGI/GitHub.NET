
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueVariant2AssigneeType
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
    public static class WebhookIssueCommentUnpinnedIssueVariant2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueVariant2AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Bot => "Bot",
                WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Organization => "Organization",
                WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueVariant2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.Organization,
                "User" => WebhookIssueCommentUnpinnedIssueVariant2AssigneeType.User,
                _ => null,
            };
        }
    }
}