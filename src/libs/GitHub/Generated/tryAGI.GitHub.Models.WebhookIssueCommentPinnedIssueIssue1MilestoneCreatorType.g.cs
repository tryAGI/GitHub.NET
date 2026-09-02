
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType
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
    public static class WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.Organization,
                "User" => WebhookIssueCommentPinnedIssueIssue1MilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}