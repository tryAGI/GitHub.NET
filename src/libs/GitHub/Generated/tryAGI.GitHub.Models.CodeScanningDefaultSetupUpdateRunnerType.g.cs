
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Runner type to be used.
    /// </summary>
    public enum CodeScanningDefaultSetupUpdateRunnerType
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
    public static class CodeScanningDefaultSetupUpdateRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateRunnerType value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateRunnerType.Labeled => "labeled",
                CodeScanningDefaultSetupUpdateRunnerType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => CodeScanningDefaultSetupUpdateRunnerType.Labeled,
                "standard" => CodeScanningDefaultSetupUpdateRunnerType.Standard,
                _ => null,
            };
        }
    }
}