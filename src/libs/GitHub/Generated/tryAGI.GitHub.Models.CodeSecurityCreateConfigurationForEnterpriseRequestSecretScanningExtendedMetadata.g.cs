
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning extended metadata<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata.NotSet,
                _ => null,
            };
        }
    }
}