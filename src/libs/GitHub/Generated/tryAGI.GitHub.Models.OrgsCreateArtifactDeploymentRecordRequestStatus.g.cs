
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The status of the artifact. Can be either deployed or decommissioned.
    /// </summary>
    public enum OrgsCreateArtifactDeploymentRecordRequestStatus
    {
        /// <summary>
        ///
        /// </summary>
        Decommissioned,
        /// <summary>
        ///
        /// </summary>
        Deployed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsCreateArtifactDeploymentRecordRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateArtifactDeploymentRecordRequestStatus value)
        {
            return value switch
            {
                OrgsCreateArtifactDeploymentRecordRequestStatus.Decommissioned => "decommissioned",
                OrgsCreateArtifactDeploymentRecordRequestStatus.Deployed => "deployed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateArtifactDeploymentRecordRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "decommissioned" => OrgsCreateArtifactDeploymentRecordRequestStatus.Decommissioned,
                "deployed" => OrgsCreateArtifactDeploymentRecordRequestStatus.Deployed,
                _ => null,
            };
        }
    }
}