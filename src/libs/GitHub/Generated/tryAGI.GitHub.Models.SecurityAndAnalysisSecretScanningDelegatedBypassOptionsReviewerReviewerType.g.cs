
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType
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
    public static class SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role => "ROLE",
                SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "ROLE" => SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role,
                "TEAM" => SecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team,
                _ => null,
            };
        }
    }
}