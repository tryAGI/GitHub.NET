
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestStackedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestBaseRepoOwnerType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestBaseRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestBaseRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestStackedPullRequestBaseRepoOwnerType.Organization,
                "User" => WebhookPullRequestStackedPullRequestBaseRepoOwnerType.User,
                _ => null,
            };
        }
    }
}