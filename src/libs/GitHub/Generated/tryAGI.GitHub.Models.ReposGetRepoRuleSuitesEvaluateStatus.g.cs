
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReposGetRepoRuleSuitesEvaluateStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Evaluate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetRepoRuleSuitesEvaluateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetRepoRuleSuitesEvaluateStatus value)
        {
            return value switch
            {
                ReposGetRepoRuleSuitesEvaluateStatus.Active => "active",
                ReposGetRepoRuleSuitesEvaluateStatus.All => "all",
                ReposGetRepoRuleSuitesEvaluateStatus.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetRepoRuleSuitesEvaluateStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ReposGetRepoRuleSuitesEvaluateStatus.Active,
                "all" => ReposGetRepoRuleSuitesEvaluateStatus.All,
                "evaluate" => ReposGetRepoRuleSuitesEvaluateStatus.Evaluate,
                _ => null,
            };
        }
    }
}