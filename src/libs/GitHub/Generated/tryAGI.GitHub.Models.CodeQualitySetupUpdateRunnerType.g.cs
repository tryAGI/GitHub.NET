
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Runner type to be used.
    /// </summary>
    public enum CodeQualitySetupUpdateRunnerType
    {
        /// <summary>
        ///
        /// </summary>
        Labeled,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupUpdateRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupUpdateRunnerType value)
        {
            return value switch
            {
                CodeQualitySetupUpdateRunnerType.Labeled => "labeled",
                CodeQualitySetupUpdateRunnerType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupUpdateRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => CodeQualitySetupUpdateRunnerType.Labeled,
                "standard" => CodeQualitySetupUpdateRunnerType.Standard,
                _ => null,
            };
        }
    }
}