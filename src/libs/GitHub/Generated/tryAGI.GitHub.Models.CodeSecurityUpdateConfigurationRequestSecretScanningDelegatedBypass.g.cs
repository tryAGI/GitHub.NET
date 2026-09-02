
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated bypass
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass.NotSet,
                _ => null,
            };
        }
    }
}