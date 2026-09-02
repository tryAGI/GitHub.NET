
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Response containing the workflow run ID and URLs.
    /// </summary>
    public sealed partial class WorkflowDispatchResponse
    {
        /// <summary>
        /// The ID of the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long WorkflowRunId { get; set; }

        /// <summary>
        /// The URL to the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDispatchResponse" /> class.
        /// </summary>
        /// <param name="workflowRunId">
        /// The ID of the workflow run.
        /// </param>
        /// <param name="runUrl">
        /// The URL to the workflow run.
        /// </param>
        /// <param name="htmlUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDispatchResponse(
            long workflowRunId,
            string runUrl,
            string htmlUrl)
        {
            this.WorkflowRunId = workflowRunId;
            this.RunUrl = runUrl ?? throw new global::System.ArgumentNullException(nameof(runUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDispatchResponse" /> class.
        /// </summary>
        public WorkflowDispatchResponse()
        {
        }

    }
}