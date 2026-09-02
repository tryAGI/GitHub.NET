
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Closed,
                "open" => WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Open,
                "secret" => WebhookPullRequestStackedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}