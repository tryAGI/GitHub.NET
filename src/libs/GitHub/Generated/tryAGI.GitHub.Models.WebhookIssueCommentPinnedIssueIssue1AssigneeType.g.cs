
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1AssigneeType
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
    public static class WebhookIssueCommentPinnedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentPinnedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentPinnedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentPinnedIssueIssue1AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentPinnedIssueIssue1AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentPinnedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentPinnedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssueCommentPinnedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}