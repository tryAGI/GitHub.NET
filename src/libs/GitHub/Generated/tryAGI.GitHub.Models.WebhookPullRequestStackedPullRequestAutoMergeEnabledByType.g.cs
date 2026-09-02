
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestAutoMergeEnabledByType
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
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
    public static class WebhookPullRequestStackedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.Bot,
                "Organization" => WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.Organization,
                "User" => WebhookPullRequestStackedPullRequestAutoMergeEnabledByType.User,
                _ => null,
            };
        }
    }
}