
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType
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
    public static class ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role => "ROLE",
                ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "ROLE" => ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Role,
                "TEAM" => ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType.Team,
                _ => null,
            };
        }
    }
}