
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether to use labeled runners or standard GitHub runners.
    /// </summary>
    public enum CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType
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
    public static class CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType value)
        {
            return value switch
            {
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Labeled => "labeled",
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.NotSet => "not_set",
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "labeled" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Labeled,
                "not_set" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.NotSet,
                "standard" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Standard,
                _ => null,
            };
        }
    }
}