
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The severity of the rule used to detect the finding.
    /// </summary>
    public enum CodeQualityFindingRuleSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Note,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualityFindingRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualityFindingRuleSeverity value)
        {
            return value switch
            {
                CodeQualityFindingRuleSeverity.Error => "error",
                CodeQualityFindingRuleSeverity.None => "none",
                CodeQualityFindingRuleSeverity.Note => "note",
                CodeQualityFindingRuleSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualityFindingRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => CodeQualityFindingRuleSeverity.Error,
                "none" => CodeQualityFindingRuleSeverity.None,
                "note" => CodeQualityFindingRuleSeverity.Note,
                "warning" => CodeQualityFindingRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}