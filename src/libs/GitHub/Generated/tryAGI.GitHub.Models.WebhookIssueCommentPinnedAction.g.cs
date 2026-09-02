
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedAction
    {
        /// <summary>
        ///
        /// </summary>
        Pinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentPinnedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedAction value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedAction.Pinned => "pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedAction? ToEnum(string value)
        {
            return value switch
            {
                "pinned" => WebhookIssueCommentPinnedAction.Pinned,
                _ => null,
            };
        }
    }
}