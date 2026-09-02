
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The deployment status of the artifact.<br/>
    /// Default Value: deployed
    /// </summary>
    public enum OrgsSetClusterDeploymentRecordsRequestDeploymentStatus
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
    public static class OrgsSetClusterDeploymentRecordsRequestDeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsSetClusterDeploymentRecordsRequestDeploymentStatus value)
        {
            return value switch
            {
                OrgsSetClusterDeploymentRecordsRequestDeploymentStatus.Decommissioned => "decommissioned",
                OrgsSetClusterDeploymentRecordsRequestDeploymentStatus.Deployed => "deployed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsSetClusterDeploymentRecordsRequestDeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "decommissioned" => OrgsSetClusterDeploymentRecordsRequestDeploymentStatus.Decommissioned,
                "deployed" => OrgsSetClusterDeploymentRecordsRequestDeploymentStatus.Deployed,
                _ => null,
            };
        }
    }
}