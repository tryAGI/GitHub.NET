
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The bypass mode for the reviewer<br/>
    /// Default Value: ALWAYS
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Always => "ALWAYS",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Exempt => "EXEMPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode? ToEnum(string value)
        {
            return value switch
            {
                "ALWAYS" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Always,
                "EXEMPT" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerMode.Exempt,
                _ => null,
            };
        }
    }
}