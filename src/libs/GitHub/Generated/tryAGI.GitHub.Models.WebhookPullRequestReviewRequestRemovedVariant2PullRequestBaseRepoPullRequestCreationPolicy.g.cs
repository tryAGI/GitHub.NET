
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy.All => "all",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy.All,
                "collaborators_only" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}