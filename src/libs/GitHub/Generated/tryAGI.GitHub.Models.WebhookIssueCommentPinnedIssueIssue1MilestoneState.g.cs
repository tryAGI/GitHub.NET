
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1MilestoneState
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentPinnedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1MilestoneState.Closed => "closed",
                WebhookIssueCommentPinnedIssueIssue1MilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentPinnedIssueIssue1MilestoneState.Closed,
                "open" => WebhookIssueCommentPinnedIssueIssue1MilestoneState.Open,
                _ => null,
            };
        }
    }
}