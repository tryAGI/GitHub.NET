
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning delegated alert dismissal<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal
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
    public static class CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}