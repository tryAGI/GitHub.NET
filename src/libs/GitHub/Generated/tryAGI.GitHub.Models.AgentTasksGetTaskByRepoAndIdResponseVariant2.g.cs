
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTasksGetTaskByRepoAndIdResponseVariant2
    {
        /// <summary>
        /// Sessions associated with this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant2Session>? Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2" /> class.
        /// </summary>
        /// <param name="sessions">
        /// Sessions associated with this task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByRepoAndIdResponseVariant2(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant2Session>? sessions)
        {
            this.Sessions = sessions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2" /> class.
        /// </summary>
        public AgentTasksGetTaskByRepoAndIdResponseVariant2()
        {
        }

    }
}