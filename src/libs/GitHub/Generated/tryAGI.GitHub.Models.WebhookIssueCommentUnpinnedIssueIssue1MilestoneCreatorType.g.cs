
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.Organization,
                "User" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}