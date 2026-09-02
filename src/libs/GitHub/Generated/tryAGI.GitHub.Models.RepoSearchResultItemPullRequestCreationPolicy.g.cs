
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy controlling who can create pull requests: all or collaborators_only.
    /// </summary>
    public enum RepoSearchResultItemPullRequestCreationPolicy
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
    public static class RepoSearchResultItemPullRequestCreationPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoSearchResultItemPullRequestCreationPolicy value)
        {
            return value switch
            {
                RepoSearchResultItemPullRequestCreationPolicy.All => "all",
                RepoSearchResultItemPullRequestCreationPolicy.CollaboratorsOnly => "collaborators_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoSearchResultItemPullRequestCreationPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all" => RepoSearchResultItemPullRequestCreationPolicy.All,
                "collaborators_only" => RepoSearchResultItemPullRequestCreationPolicy.CollaboratorsOnly,
                _ => null,
            };
        }
    }
}