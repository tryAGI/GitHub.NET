
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning extended metadata
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata.NotSet,
                _ => null,
            };
        }
    }
}