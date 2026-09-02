
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningDelegatedBypassStatus
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
    public static class SecurityAndAnalysisSecretScanningDelegatedBypassStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningDelegatedBypassStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningDelegatedBypassStatus.Disabled => "disabled",
                SecurityAndAnalysisSecretScanningDelegatedBypassStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningDelegatedBypassStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisSecretScanningDelegatedBypassStatus.Disabled,
                "enabled" => SecurityAndAnalysisSecretScanningDelegatedBypassStatus.Enabled,
                _ => null,
            };
        }
    }
}