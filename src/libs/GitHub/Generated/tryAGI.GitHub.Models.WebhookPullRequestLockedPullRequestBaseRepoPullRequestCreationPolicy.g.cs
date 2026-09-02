
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy
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
    public static class WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy.All => "all",
                WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy.All,
                "collaborators_only" => WebhookPullRequestLockedPullRequestBaseRepoPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}