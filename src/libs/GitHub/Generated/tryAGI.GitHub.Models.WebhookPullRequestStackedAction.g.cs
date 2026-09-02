
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedAction
    {
        /// <summary>
        ///
        /// </summary>
        Stacked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedAction value)
        {
            return value switch
            {
                WebhookPullRequestStackedAction.Stacked => "stacked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedAction? ToEnum(string value)
        {
            return value switch
            {
                "stacked" => WebhookPullRequestStackedAction.Stacked,
                _ => null,
            };
        }
    }
}