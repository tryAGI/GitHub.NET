
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1State
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1State value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1State.Closed => "closed",
                WebhookIssueCommentUnpinnedIssueIssue1State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentUnpinnedIssueIssue1State.Closed,
                "open" => WebhookIssueCommentUnpinnedIssueIssue1State.Open,
                _ => null,
            };
        }
    }
}