
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType
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
    public static class CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role => "ROLE",
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "ROLE" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role,
                "TEAM" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team,
                _ => null,
            };
        }
    }
}