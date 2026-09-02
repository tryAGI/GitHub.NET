
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum NullableMinimalRepositoryPullRequestCreationPolicy
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
    public static class NullableMinimalRepositoryPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableMinimalRepositoryPullRequestCreationPolicy value)
        {
            return value switch
            {
                NullableMinimalRepositoryPullRequestCreationPolicy.All => "all",
                NullableMinimalRepositoryPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableMinimalRepositoryPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => NullableMinimalRepositoryPullRequestCreationPolicy.All,
                "collaborators_only" => NullableMinimalRepositoryPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}