
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1MilestoneState
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneState.Closed => "closed",
                WebhookIssueCommentUnpinnedIssueIssue1MilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneState.Closed,
                "open" => WebhookIssueCommentUnpinnedIssueIssue1MilestoneState.Open,
                _ => null,
            };
        }
    }
}