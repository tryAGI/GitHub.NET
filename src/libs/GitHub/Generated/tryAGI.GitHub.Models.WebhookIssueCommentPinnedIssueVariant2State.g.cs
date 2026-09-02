
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueVariant2State
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
    public static class WebhookIssueCommentPinnedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueVariant2State.Closed => "closed",
                WebhookIssueCommentPinnedIssueVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentPinnedIssueVariant2State.Closed,
                "open" => WebhookIssueCommentPinnedIssueVariant2State.Open,
                _ => null,
            };
        }
    }
}