
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestMilestoneState
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
    public static class WebhookPullRequestStackedPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestStackedPullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestStackedPullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestStackedPullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}