
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Secret Protection features.
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection.NotSet,
                _ => null,
            };
        }
    }
}