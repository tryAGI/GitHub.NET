
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestAssigneeType2
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
        /// <summary>
        ///
        /// </summary>
        Mannequin,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestStackedPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestStackedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestStackedPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestStackedPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestStackedPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestStackedPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}