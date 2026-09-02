
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueVariant2State
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
    public static class WebhookIssueCommentUnpinnedIssueVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueVariant2State value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueVariant2State.Closed => "closed",
                WebhookIssueCommentUnpinnedIssueVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentUnpinnedIssueVariant2State.Closed,
                "open" => WebhookIssueCommentUnpinnedIssueVariant2State.Open,
                _ => null,
            };
        }
    }
}