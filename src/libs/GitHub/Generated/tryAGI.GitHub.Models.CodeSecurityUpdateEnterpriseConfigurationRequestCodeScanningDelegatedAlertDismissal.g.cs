
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning delegated alert dismissal<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}