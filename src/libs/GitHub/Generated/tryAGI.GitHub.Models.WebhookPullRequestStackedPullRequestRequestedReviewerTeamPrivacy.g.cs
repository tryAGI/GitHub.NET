
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Closed,
                "open" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Open,
                "secret" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}