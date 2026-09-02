
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of GitHub Secret Protection features.
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretProtection
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
    public static class CodeSecurityUpdateConfigurationRequestSecretProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretProtection value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretProtection.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretProtection.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretProtection.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretProtection.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretProtection.NotSet,
                _ => null,
            };
        }
    }
}