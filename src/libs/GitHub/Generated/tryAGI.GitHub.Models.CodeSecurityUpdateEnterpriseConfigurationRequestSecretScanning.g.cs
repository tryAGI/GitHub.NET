
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}