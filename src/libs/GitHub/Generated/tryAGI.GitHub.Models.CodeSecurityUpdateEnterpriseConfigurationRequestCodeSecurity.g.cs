
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Code Security features.
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity.NotSet,
                _ => null,
            };
        }
    }
}