
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestUserType
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
    public static class WebhookPullRequestStackedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestStackedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestStackedPullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestStackedPullRequestUserType.Organization,
                "User" => WebhookPullRequestStackedPullRequestUserType.User,
                _ => null,
            };
        }
    }
}