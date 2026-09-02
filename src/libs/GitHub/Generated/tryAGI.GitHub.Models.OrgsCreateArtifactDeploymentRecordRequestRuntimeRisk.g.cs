
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk
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
    public static class OrgsCreateArtifactDeploymentRecordRequestRuntimeRiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk value)
        {
            return value switch
            {
                OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.CriticalResource => "critical-resource",
                OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.InternetExposed => "internet-exposed",
                OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.LateralMovement => "lateral-movement",
                OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.SensitiveData => "sensitive-data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk? ToEnum(string value)
        {
            return value switch
            {
                "critical-resource" => OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.CriticalResource,
                "internet-exposed" => OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.InternetExposed,
                "lateral-movement" => OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.LateralMovement,
                "sensitive-data" => OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk.SensitiveData,
                _ => null,
            };
        }
    }
}