
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The bypass mode for the reviewer<br/>
    /// Default Value: ALWAYS
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Always => "ALWAYS",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Exempt => "EXEMPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode? ToEnum(string value)
        {
            return value switch
            {
                "ALWAYS" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Always,
                "EXEMPT" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Exempt,
                _ => null,
            };
        }
    }
}