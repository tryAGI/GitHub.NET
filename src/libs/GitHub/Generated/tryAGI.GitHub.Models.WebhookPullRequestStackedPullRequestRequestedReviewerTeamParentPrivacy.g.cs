
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy
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
    public static class WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Open => "open",
                WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Closed,
                "open" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Open,
                "secret" => WebhookPullRequestStackedPullRequestRequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}