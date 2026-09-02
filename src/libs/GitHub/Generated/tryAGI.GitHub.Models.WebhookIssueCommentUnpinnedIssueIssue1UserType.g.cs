
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1UserType
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentUnpinnedIssueIssue1UserType.Mannequin => "Mannequin",
                WebhookIssueCommentUnpinnedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentUnpinnedIssueIssue1UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentUnpinnedIssueIssue1UserType.Bot,
                "Mannequin" => WebhookIssueCommentUnpinnedIssueIssue1UserType.Mannequin,
                "Organization" => WebhookIssueCommentUnpinnedIssueIssue1UserType.Organization,
                "User" => WebhookIssueCommentUnpinnedIssueIssue1UserType.User,
                _ => null,
            };
        }
    }
}