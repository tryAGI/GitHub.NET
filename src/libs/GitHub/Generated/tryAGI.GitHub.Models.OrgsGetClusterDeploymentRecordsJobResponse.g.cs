
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsGetClusterDeploymentRecordsJobResponse
    {
        /// <summary>
        /// The ID of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

        /// <summary>
        /// The current status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsGetClusterDeploymentRecordsJobResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrgsGetClusterDeploymentRecordsJobResponseStatus Status { get; set; }

        /// <summary>
        /// When the job started processing (only present when processing, completed, or failed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The number of records successfully mutated (only present when completed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Processing errors (only present when completed or failed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<object>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsGetClusterDeploymentRecordsJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job.
        /// </param>
        /// <param name="status">
        /// The current status of the job.
        /// </param>
        /// <param name="startedAt">
        /// When the job started processing (only present when processing, completed, or failed).
        /// </param>
        /// <param name="totalCount">
        /// The number of records successfully mutated (only present when completed).
        /// </param>
        /// <param name="errors">
        /// Processing errors (only present when completed or failed).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsGetClusterDeploymentRecordsJobResponse(
            int jobId,
            global::tryAGI.GitHub.OrgsGetClusterDeploymentRecordsJobResponseStatus status,
            global::System.DateTime? startedAt,
            int? totalCount,
            global::System.Collections.Generic.IList<object>? errors)
        {
            this.JobId = jobId;
            this.Status = status;
            this.StartedAt = startedAt;
            this.TotalCount = totalCount;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsGetClusterDeploymentRecordsJobResponse" /> class.
        /// </summary>
        public OrgsGetClusterDeploymentRecordsJobResponse()
        {
        }

    }
}