
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestStackedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestStackedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestStackedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}