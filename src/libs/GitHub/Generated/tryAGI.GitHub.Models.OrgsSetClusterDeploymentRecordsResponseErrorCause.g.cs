
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The reason the deployment failed processing.
    /// </summary>
    public enum OrgsSetClusterDeploymentRecordsResponseErrorCause
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsSetClusterDeploymentRecordsResponseErrorCauseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsSetClusterDeploymentRecordsResponseErrorCause value)
        {
            return value switch
            {
                OrgsSetClusterDeploymentRecordsResponseErrorCause.NotFound => "not_found",
                OrgsSetClusterDeploymentRecordsResponseErrorCause.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsSetClusterDeploymentRecordsResponseErrorCause? ToEnum(string value)
        {
            return value switch
            {
                "not_found" => OrgsSetClusterDeploymentRecordsResponseErrorCause.NotFound,
                "unauthorized" => OrgsSetClusterDeploymentRecordsResponseErrorCause.Unauthorized,
                _ => null,
            };
        }
    }
}