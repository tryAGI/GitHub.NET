
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum MinimalRepositoryPullRequestCreationPolicy
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
    public static class MinimalRepositoryPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimalRepositoryPullRequestCreationPolicy value)
        {
            return value switch
            {
                MinimalRepositoryPullRequestCreationPolicy.All => "all",
                MinimalRepositoryPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimalRepositoryPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => MinimalRepositoryPullRequestCreationPolicy.All,
                "collaborators_only" => MinimalRepositoryPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}