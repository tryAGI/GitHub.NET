
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1AssigneeType
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssueCommentUnpinnedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}