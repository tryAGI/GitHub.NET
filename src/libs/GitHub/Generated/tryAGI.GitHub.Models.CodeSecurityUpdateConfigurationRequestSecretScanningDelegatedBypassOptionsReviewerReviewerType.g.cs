
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role => "ROLE",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "ROLE" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role,
                "TEAM" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team,
                _ => null,
            };
        }
    }
}