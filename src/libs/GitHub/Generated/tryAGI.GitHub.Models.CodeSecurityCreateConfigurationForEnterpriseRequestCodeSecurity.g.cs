
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Code Security features.
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.NotSet,
                _ => null,
            };
        }
    }
}