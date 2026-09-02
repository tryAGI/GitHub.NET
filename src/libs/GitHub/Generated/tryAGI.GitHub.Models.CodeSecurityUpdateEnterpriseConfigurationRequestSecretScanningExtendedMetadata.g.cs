
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning extended metadata<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata.NotSet,
                _ => null,
            };
        }
    }
}