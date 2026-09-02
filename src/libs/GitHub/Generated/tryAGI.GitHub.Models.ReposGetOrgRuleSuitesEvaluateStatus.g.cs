
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReposGetOrgRuleSuitesEvaluateStatus
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
    public static class ReposGetOrgRuleSuitesEvaluateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetOrgRuleSuitesEvaluateStatus value)
        {
            return value switch
            {
                ReposGetOrgRuleSuitesEvaluateStatus.Active => "active",
                ReposGetOrgRuleSuitesEvaluateStatus.All => "all",
                ReposGetOrgRuleSuitesEvaluateStatus.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetOrgRuleSuitesEvaluateStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ReposGetOrgRuleSuitesEvaluateStatus.Active,
                "all" => ReposGetOrgRuleSuitesEvaluateStatus.All,
                "evaluate" => ReposGetOrgRuleSuitesEvaluateStatus.Evaluate,
                _ => null,
            };
        }
    }
}