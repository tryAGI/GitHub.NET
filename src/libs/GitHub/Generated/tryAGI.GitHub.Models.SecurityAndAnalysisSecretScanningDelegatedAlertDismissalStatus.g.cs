
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus.Disabled => "disabled",
                SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus.Disabled,
                "enabled" => SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus.Enabled,
                _ => null,
            };
        }
    }
}