
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated alert dismissal
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}