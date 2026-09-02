
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The current status of the job.
    /// </summary>
    public enum OrgsGetClusterDeploymentRecordsJobResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsGetClusterDeploymentRecordsJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsGetClusterDeploymentRecordsJobResponseStatus value)
        {
            return value switch
            {
                OrgsGetClusterDeploymentRecordsJobResponseStatus.Completed => "completed",
                OrgsGetClusterDeploymentRecordsJobResponseStatus.Failed => "failed",
                OrgsGetClusterDeploymentRecordsJobResponseStatus.Pending => "pending",
                OrgsGetClusterDeploymentRecordsJobResponseStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsGetClusterDeploymentRecordsJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OrgsGetClusterDeploymentRecordsJobResponseStatus.Completed,
                "failed" => OrgsGetClusterDeploymentRecordsJobResponseStatus.Failed,
                "pending" => OrgsGetClusterDeploymentRecordsJobResponseStatus.Pending,
                "processing" => OrgsGetClusterDeploymentRecordsJobResponseStatus.Processing,
                _ => null,
            };
        }
    }
}