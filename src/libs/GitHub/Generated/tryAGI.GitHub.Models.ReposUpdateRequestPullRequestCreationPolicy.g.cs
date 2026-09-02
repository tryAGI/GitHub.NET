
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy that controls who can create pull requests for this repository: `all` or `collaborators_only`.
    /// </summary>
    public enum ReposUpdateRequestPullRequestCreationPolicy
    {
        /// <summary>
        /// `all` or `collaborators_only`.
        /// </summary>
        All,
        /// <summary>
        /// `all` or `collaborators_only`.
        /// </summary>
        CollaboratorsOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRequestPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestPullRequestCreationPolicy value)
        {
            return value switch
            {
                ReposUpdateRequestPullRequestCreationPolicy.All => "all",
                ReposUpdateRequestPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposUpdateRequestPullRequestCreationPolicy.All,
                "collaborators_only" => ReposUpdateRequestPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}