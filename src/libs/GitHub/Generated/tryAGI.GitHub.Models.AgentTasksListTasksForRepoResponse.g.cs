
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTasksListTasksForRepoResponse
    {
        /// <summary>
        /// List of tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksListTasksForRepoResponseTask> Tasks { get; set; }

        /// <summary>
        /// Total count of active (non-archived) tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_count")]
        public int? TotalActiveCount { get; set; }

        /// <summary>
        /// Total count of archived tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_archived_count")]
        public int? TotalArchivedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksListTasksForRepoResponse" /> class.
        /// </summary>
        /// <param name="tasks">
        /// List of tasks
        /// </param>
        /// <param name="totalActiveCount">
        /// Total count of active (non-archived) tasks
        /// </param>
        /// <param name="totalArchivedCount">
        /// Total count of archived tasks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksListTasksForRepoResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksListTasksForRepoResponseTask> tasks,
            int? totalActiveCount,
            int? totalArchivedCount)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
            this.TotalActiveCount = totalActiveCount;
            this.TotalArchivedCount = totalArchivedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksListTasksForRepoResponse" /> class.
        /// </summary>
        public AgentTasksListTasksForRepoResponse()
        {
        }

    }
}