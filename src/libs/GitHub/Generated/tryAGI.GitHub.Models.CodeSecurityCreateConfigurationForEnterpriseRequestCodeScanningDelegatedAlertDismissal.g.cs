
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning delegated alert dismissal<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}