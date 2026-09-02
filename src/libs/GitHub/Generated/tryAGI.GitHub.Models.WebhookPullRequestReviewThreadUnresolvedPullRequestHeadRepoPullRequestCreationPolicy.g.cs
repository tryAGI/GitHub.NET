
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy
    {
        /// <summary>
        /// all or collaborators_only.
        /// </summary>
        All,
        /// <summary>
        /// all or collaborators_only.
        /// </summary>
        CollaboratorsOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy.All => "all",
                WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy.All,
                "collaborators_only" => WebhookPullRequestReviewThreadUnresolvedPullRequestHeadRepoPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}