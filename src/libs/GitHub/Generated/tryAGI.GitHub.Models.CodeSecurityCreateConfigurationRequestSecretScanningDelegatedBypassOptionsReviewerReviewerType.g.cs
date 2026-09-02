
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType
    {
        /// <summary>
        ///
        /// </summary>
        Role,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role => "ROLE",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "ROLE" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role,
                "TEAM" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team,
                _ => null,
            };
        }
    }
}