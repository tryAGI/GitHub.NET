
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum RepositoryRulePullRequestParametersAllowedMergeMethod
    {
        /// <summary>
        ///
        /// </summary>
        Merge,
        /// <summary>
        ///
        /// </summary>
        Rebase,
        /// <summary>
        ///
        /// </summary>
        Squash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulePullRequestParametersAllowedMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulePullRequestParametersAllowedMergeMethod value)
        {
            return value switch
            {
                RepositoryRulePullRequestParametersAllowedMergeMethod.Merge => "merge",
                RepositoryRulePullRequestParametersAllowedMergeMethod.Rebase => "rebase",
                RepositoryRulePullRequestParametersAllowedMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulePullRequestParametersAllowedMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => RepositoryRulePullRequestParametersAllowedMergeMethod.Merge,
                "rebase" => RepositoryRulePullRequestParametersAllowedMergeMethod.Rebase,
                "squash" => RepositoryRulePullRequestParametersAllowedMergeMethod.Squash,
                _ => null,
            };
        }
    }
}