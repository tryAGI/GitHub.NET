
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning delegated alert dismissal<br/>
    /// Default Value: not_set
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal
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
    public static class CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}