
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The category of the rule used to detect the finding.
    /// </summary>
    public enum CodeQualityFindingRuleCategory
    {
        /// <summary>
        ///
        /// </summary>
        Maintainability,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Reliability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualityFindingRuleCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualityFindingRuleCategory value)
        {
            return value switch
            {
                CodeQualityFindingRuleCategory.Maintainability => "maintainability",
                CodeQualityFindingRuleCategory.None => "none",
                CodeQualityFindingRuleCategory.Reliability => "reliability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualityFindingRuleCategory? ToEnum(string value)
        {
            return value switch
            {
                "maintainability" => CodeQualityFindingRuleCategory.Maintainability,
                "none" => CodeQualityFindingRuleCategory.None,
                "reliability" => CodeQualityFindingRuleCategory.Reliability,
                _ => null,
            };
        }
    }
}