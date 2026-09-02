
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
    /// &gt; [!WARNING]<br/>
    /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestAdvancedSecurity
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
    public static class CodeSecurityUpdateConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "code_security" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.CodeSecurity,
                "disabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled,
                "secret_protection" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}