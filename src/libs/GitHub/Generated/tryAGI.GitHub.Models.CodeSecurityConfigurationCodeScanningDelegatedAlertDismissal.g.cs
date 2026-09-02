
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning delegated alert dismissal
    /// </summary>
    public enum CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal
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
    public static class CodeSecurityConfigurationCodeScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}