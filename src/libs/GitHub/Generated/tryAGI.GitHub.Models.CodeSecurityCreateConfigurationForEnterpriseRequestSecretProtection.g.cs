
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Secret Protection features.
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection.NotSet,
                _ => null,
            };
        }
    }
}