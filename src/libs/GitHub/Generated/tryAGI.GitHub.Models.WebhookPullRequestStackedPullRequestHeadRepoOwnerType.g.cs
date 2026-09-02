
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestStackedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestHeadRepoOwnerType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestHeadRepoOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestHeadRepoOwnerType.Bot,
                "Organization" => WebhookPullRequestStackedPullRequestHeadRepoOwnerType.Organization,
                "User" => WebhookPullRequestStackedPullRequestHeadRepoOwnerType.User,
                _ => null,
            };
        }
    }
}