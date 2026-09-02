
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Code Security features.
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestCodeSecurity
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
    public static class CodeSecurityCreateConfigurationRequestCodeSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestCodeSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestCodeSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestCodeSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestCodeSecurity.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestCodeSecurity? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestCodeSecurity.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestCodeSecurity.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestCodeSecurity.NotSet,
                _ => null,
            };
        }
    }
}