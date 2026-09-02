
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning push protection
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection.NotSet,
                _ => null,
            };
        }
    }
}