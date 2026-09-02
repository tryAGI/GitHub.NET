
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether to use labeled runners or standard GitHub runners.
    /// </summary>
    public enum CodeScanningDefaultSetupOptionsRunnerType
    {
        /// <summary>
        ///
        /// </summary>
        Labeled,
        /// <summary>
        ///
        /// </summary>
        NotSet,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupOptionsRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupOptionsRunnerType value)
        {
            return value switch
            {
                CodeScanningDefaultSetupOptionsRunnerType.Labeled => "labeled",
                CodeScanningDefaultSetupOptionsRunnerType.NotSet => "not_set",
                CodeScanningDefaultSetupOptionsRunnerType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupOptionsRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => CodeScanningDefaultSetupOptionsRunnerType.Labeled,
                "not_set" => CodeScanningDefaultSetupOptionsRunnerType.NotSet,
                "standard" => CodeScanningDefaultSetupOptionsRunnerType.Standard,
                _ => null,
            };
        }
    }
}