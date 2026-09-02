
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy.All => "all",
                WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy.All,
                "collaborators_only" => WebhookPullRequestReviewCommentCreatedPullRequestHeadRepoPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}