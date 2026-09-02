
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestMergedByType
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
    public static class WebhookPullRequestStackedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestMergedByType.Mannequin => "Mannequin",
                WebhookPullRequestStackedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestMergedByType.Bot,
                "Mannequin" => WebhookPullRequestStackedPullRequestMergedByType.Mannequin,
                "Organization" => WebhookPullRequestStackedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestStackedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}