
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning extended metadata
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningExtendedMetadata
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
    public static class CodeSecurityConfigurationSecretScanningExtendedMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningExtendedMetadata value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningExtendedMetadata.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningExtendedMetadata.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningExtendedMetadata.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningExtendedMetadata? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityConfigurationSecretScanningExtendedMetadata.Disabled,
                "enabled" => CodeSecurityConfigurationSecretScanningExtendedMetadata.Enabled,
                "not_set" => CodeSecurityConfigurationSecretScanningExtendedMetadata.NotSet,
                _ => null,
            };
        }
    }
}