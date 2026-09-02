
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated alert dismissal
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}