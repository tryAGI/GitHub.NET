
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy.All => "all",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy.All,
                "collaborators_only" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}