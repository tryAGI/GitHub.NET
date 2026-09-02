
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Code Security features.
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestCodeSecurity
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
    public static class CodeSecurityUpdateConfigurationRequestCodeSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestCodeSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestCodeSecurity.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestCodeSecurity.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestCodeSecurity.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestCodeSecurity? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestCodeSecurity.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestCodeSecurity.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestCodeSecurity.NotSet,
                _ => null,
            };
        }
    }
}