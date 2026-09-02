
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestBaseUserType
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
    public static class WebhookPullRequestStackedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestStackedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestStackedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}