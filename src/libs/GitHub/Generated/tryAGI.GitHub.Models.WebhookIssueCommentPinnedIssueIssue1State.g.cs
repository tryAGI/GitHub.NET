
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1State
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
    public static class WebhookIssueCommentPinnedIssueIssue1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1State value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1State.Closed => "closed",
                WebhookIssueCommentPinnedIssueIssue1State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentPinnedIssueIssue1State.Closed,
                "open" => WebhookIssueCommentPinnedIssueIssue1State.Open,
                _ => null,
            };
        }
    }
}