
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning extended metadata
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata.NotSet,
                _ => null,
            };
        }
    }
}