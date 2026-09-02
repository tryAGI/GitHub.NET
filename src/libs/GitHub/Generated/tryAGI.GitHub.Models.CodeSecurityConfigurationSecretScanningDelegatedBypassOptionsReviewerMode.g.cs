
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The bypass mode for the reviewer<br/>
    /// Default Value: ALWAYS
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        Exempt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode.Always => "ALWAYS",
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode.Exempt => "EXEMPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode? ToEnum(string value)
        {
            return value switch
            {
                "ALWAYS" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode.Always,
                "EXEMPT" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerMode.Exempt,
                _ => null,
            };
        }
    }
}