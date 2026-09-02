
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The deployment status of the artifact.<br/>
    /// Default Value: deployed
    /// </summary>
    public enum OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus
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
    public static class OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus value)
        {
            return value switch
            {
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus.Decommissioned => "decommissioned",
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus.Deployed => "deployed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus? ToEnum(string value)
        {
            return value switch
            {
                "decommissioned" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus.Decommissioned,
                "deployed" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus.Deployed,
                _ => null,
            };
        }
    }
}