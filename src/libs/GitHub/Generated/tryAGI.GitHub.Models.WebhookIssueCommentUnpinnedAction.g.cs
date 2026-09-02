
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedAction
    {
        /// <summary>
        ///
        /// </summary>
        Unpinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentUnpinnedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedAction value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedAction.Unpinned => "unpinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedAction? ToEnum(string value)
        {
            return value switch
            {
                "unpinned" => WebhookIssueCommentUnpinnedAction.Unpinned,
                _ => null,
            };
        }
    }
}