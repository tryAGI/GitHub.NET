
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk
    {
        /// <summary>
        ///
        /// </summary>
        CriticalResource,
        /// <summary>
        ///
        /// </summary>
        InternetExposed,
        /// <summary>
        ///
        /// </summary>
        LateralMovement,
        /// <summary>
        ///
        /// </summary>
        SensitiveData,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk value)
        {
            return value switch
            {
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.CriticalResource => "critical-resource",
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.InternetExposed => "internet-exposed",
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.LateralMovement => "lateral-movement",
                OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.SensitiveData => "sensitive-data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk? ToEnum(string value)
        {
            return value switch
            {
                "critical-resource" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.CriticalResource,
                "internet-exposed" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.InternetExposed,
                "lateral-movement" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.LateralMovement,
                "sensitive-data" => OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk.SensitiveData,
                _ => null,
            };
        }
    }
}