
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
    /// &gt; [!WARNING]<br/>
    /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity
    {
        /// <summary>
        ///
        /// </summary>
        CodeSecurity,
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
        SecretProtection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "code_security" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.CodeSecurity,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Enabled,
                "secret_protection" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}