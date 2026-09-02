
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateClusterDeploymentRecordsJobResponse
    {
        /// <summary>
        /// The ID of the created job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// Deployments that were rejected during authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<object>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the created job.
        /// </param>
        /// <param name="errors">
        /// Deployments that were rejected during authorization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateClusterDeploymentRecordsJobResponse(
            int jobId,
            global::System.Collections.Generic.IList<object>? errors)
        {
            this.JobId = jobId;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobResponse" /> class.
        /// </summary>
        public OrgsCreateClusterDeploymentRecordsJobResponse()
        {
        }

    }
}