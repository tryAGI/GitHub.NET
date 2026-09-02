
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security
    /// </summary>
    public enum CodeSecurityConfigurationAdvancedSecurity
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
    public static class CodeSecurityConfigurationAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityConfigurationAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityConfigurationAdvancedSecurity.Disabled => "disabled",
                CodeSecurityConfigurationAdvancedSecurity.Enabled => "enabled",
                CodeSecurityConfigurationAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "code_security" => CodeSecurityConfigurationAdvancedSecurity.CodeSecurity,
                "disabled" => CodeSecurityConfigurationAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityConfigurationAdvancedSecurity.Enabled,
                "secret_protection" => CodeSecurityConfigurationAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}