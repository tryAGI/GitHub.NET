
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestAssigneeType
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
    public static class WebhookPullRequestStackedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestStackedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestStackedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestStackedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestStackedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestStackedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestStackedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestStackedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}