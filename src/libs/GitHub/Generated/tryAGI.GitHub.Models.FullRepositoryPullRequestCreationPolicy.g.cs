
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.<br/>
    /// Example: all
    /// </summary>
    public enum FullRepositoryPullRequestCreationPolicy
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
    public static class FullRepositoryPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FullRepositoryPullRequestCreationPolicy value)
        {
            return value switch
            {
                FullRepositoryPullRequestCreationPolicy.All => "all",
                FullRepositoryPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FullRepositoryPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => FullRepositoryPullRequestCreationPolicy.All,
                "collaborators_only" => FullRepositoryPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}