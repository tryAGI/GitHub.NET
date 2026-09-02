
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ArtifactDeploymentRecordRuntimeRisk
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
    public static class ArtifactDeploymentRecordRuntimeRiskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactDeploymentRecordRuntimeRisk value)
        {
            return value switch
            {
                ArtifactDeploymentRecordRuntimeRisk.CriticalResource => "critical-resource",
                ArtifactDeploymentRecordRuntimeRisk.InternetExposed => "internet-exposed",
                ArtifactDeploymentRecordRuntimeRisk.LateralMovement => "lateral-movement",
                ArtifactDeploymentRecordRuntimeRisk.SensitiveData => "sensitive-data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactDeploymentRecordRuntimeRisk? ToEnum(string value)
        {
            return value switch
            {
                "critical-resource" => ArtifactDeploymentRecordRuntimeRisk.CriticalResource,
                "internet-exposed" => ArtifactDeploymentRecordRuntimeRisk.InternetExposed,
                "lateral-movement" => ArtifactDeploymentRecordRuntimeRisk.LateralMovement,
                "sensitive-data" => ArtifactDeploymentRecordRuntimeRisk.SensitiveData,
                _ => null,
            };
        }
    }
}