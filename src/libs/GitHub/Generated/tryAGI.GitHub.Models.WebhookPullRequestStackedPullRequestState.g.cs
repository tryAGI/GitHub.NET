
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestState
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
    public static class WebhookPullRequestStackedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestState.Closed => "closed",
                WebhookPullRequestStackedPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestStackedPullRequestState.Closed,
                "open" => WebhookPullRequestStackedPullRequestState.Open,
                _ => null,
            };
        }
    }
}