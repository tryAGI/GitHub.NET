
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestHeadUserType
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
    public static class WebhookPullRequestStackedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestStackedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestStackedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}