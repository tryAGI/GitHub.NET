
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConcurrencyGroupRunListConcurrencyGroupGroupMember
    {
        /// <summary>
        /// The ID of the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunId { get; set; }

        /// <summary>
        /// The name of the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunName { get; set; }

        /// <summary>
        /// API URL for the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_url")]
        public string? RunUrl { get; set; }

        /// <summary>
        /// Web URL for the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_html_url")]
        public string? RunHtmlUrl { get; set; }

        /// <summary>
        /// Queue position. 0 means the item holds the concurrency lease (in_progress), 1 or higher means queued (pending).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// API URL to get items ahead of this item in the concurrency group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PositionUrl { get; set; }

        /// <summary>
        /// The ID of the job, when the item represents a job-level or reusable-workflow-level lease.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public int? JobId { get; set; }

        /// <summary>
        /// The display name of the job, when the item represents a job-level or reusable-workflow-level lease.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_name")]
        public string? JobName { get; set; }

        /// <summary>
        /// API URL for the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_url")]
        public string? JobUrl { get; set; }

        /// <summary>
        /// Web URL for the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_html_url")]
        public string? JobHtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunListConcurrencyGroupGroupMember" /> class.
        /// </summary>
        /// <param name="runId">
        /// The ID of the workflow run.
        /// </param>
        /// <param name="runName">
        /// The name of the workflow run.
        /// </param>
        /// <param name="position">
        /// Queue position. 0 means the item holds the concurrency lease (in_progress), 1 or higher means queued (pending).
        /// </param>
        /// <param name="positionUrl">
        /// API URL to get items ahead of this item in the concurrency group.
        /// </param>
        /// <param name="status"></param>
        /// <param name="runUrl">
        /// API URL for the workflow run.
        /// </param>
        /// <param name="runHtmlUrl">
        /// Web URL for the workflow run.
        /// </param>
        /// <param name="jobId">
        /// The ID of the job, when the item represents a job-level or reusable-workflow-level lease.
        /// </param>
        /// <param name="jobName">
        /// The display name of the job, when the item represents a job-level or reusable-workflow-level lease.
        /// </param>
        /// <param name="jobUrl">
        /// API URL for the job.
        /// </param>
        /// <param name="jobHtmlUrl">
        /// Web URL for the job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroupRunListConcurrencyGroupGroupMember(
            int runId,
            string runName,
            int position,
            string positionUrl,
            global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus status,
            string? runUrl,
            string? runHtmlUrl,
            int? jobId,
            string? jobName,
            string? jobUrl,
            string? jobHtmlUrl)
        {
            this.RunId = runId;
            this.RunName = runName ?? throw new global::System.ArgumentNullException(nameof(runName));
            this.RunUrl = runUrl;
            this.RunHtmlUrl = runHtmlUrl;
            this.Position = position;
            this.PositionUrl = positionUrl ?? throw new global::System.ArgumentNullException(nameof(positionUrl));
            this.JobId = jobId;
            this.JobName = jobName;
            this.JobUrl = jobUrl;
            this.JobHtmlUrl = jobHtmlUrl;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunListConcurrencyGroupGroupMember" /> class.
        /// </summary>
        public ConcurrencyGroupRunListConcurrencyGroupGroupMember()
        {
        }

    }
}