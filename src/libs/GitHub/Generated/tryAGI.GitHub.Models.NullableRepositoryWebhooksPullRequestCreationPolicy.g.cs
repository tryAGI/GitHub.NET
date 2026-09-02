
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum NullableRepositoryWebhooksPullRequestCreationPolicy
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
    public static class NullableRepositoryWebhooksPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksPullRequestCreationPolicy value)
        {
            return value switch
            {
                NullableRepositoryWebhooksPullRequestCreationPolicy.All => "all",
                NullableRepositoryWebhooksPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => NullableRepositoryWebhooksPullRequestCreationPolicy.All,
                "collaborators_only" => NullableRepositoryWebhooksPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}