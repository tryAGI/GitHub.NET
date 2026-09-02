
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk
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
    public static class OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk value)
        {
            return value switch
            {
                OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.CriticalResource => "critical-resource",
                OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.InternetExposed => "internet-exposed",
                OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.LateralMovement => "lateral-movement",
                OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.SensitiveData => "sensitive-data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk? ToEnum(string value)
        {
            return value switch
            {
                "critical-resource" => OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.CriticalResource,
                "internet-exposed" => OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.InternetExposed,
                "lateral-movement" => OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.LateralMovement,
                "sensitive-data" => OrgsSetClusterDeploymentRecordsRequestDeploymentRuntimeRisk.SensitiveData,
                _ => null,
            };
        }
    }
}