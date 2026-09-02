
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
    /// &gt; [!WARNING]<br/>
    /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "code_security" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.CodeSecurity,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Enabled,
                "secret_protection" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}