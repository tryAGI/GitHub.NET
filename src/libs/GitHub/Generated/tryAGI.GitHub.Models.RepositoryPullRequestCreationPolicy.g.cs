
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.<br/>
    /// Example: all
    /// </summary>
    public enum RepositoryPullRequestCreationPolicy
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
    public static class RepositoryPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryPullRequestCreationPolicy value)
        {
            return value switch
            {
                RepositoryPullRequestCreationPolicy.All => "all",
                RepositoryPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => RepositoryPullRequestCreationPolicy.All,
                "collaborators_only" => RepositoryPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}