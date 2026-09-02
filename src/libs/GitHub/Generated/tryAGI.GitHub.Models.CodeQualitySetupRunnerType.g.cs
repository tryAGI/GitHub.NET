
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Runner type to be used.
    /// </summary>
    public enum CodeQualitySetupRunnerType
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
    public static class CodeQualitySetupRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupRunnerType value)
        {
            return value switch
            {
                CodeQualitySetupRunnerType.Labeled => "labeled",
                CodeQualitySetupRunnerType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => CodeQualitySetupRunnerType.Labeled,
                "standard" => CodeQualitySetupRunnerType.Standard,
                _ => null,
            };
        }
    }
}