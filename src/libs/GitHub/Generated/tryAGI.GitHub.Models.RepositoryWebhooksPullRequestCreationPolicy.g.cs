
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum RepositoryWebhooksPullRequestCreationPolicy
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
    public static class RepositoryWebhooksPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksPullRequestCreationPolicy value)
        {
            return value switch
            {
                RepositoryWebhooksPullRequestCreationPolicy.All => "all",
                RepositoryWebhooksPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => RepositoryWebhooksPullRequestCreationPolicy.All,
                "collaborators_only" => RepositoryWebhooksPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}