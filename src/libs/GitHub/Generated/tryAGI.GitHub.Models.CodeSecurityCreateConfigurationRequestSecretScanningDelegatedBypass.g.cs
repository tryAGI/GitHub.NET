
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated bypass<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.NotSet,
                _ => null,
            };
        }
    }
}