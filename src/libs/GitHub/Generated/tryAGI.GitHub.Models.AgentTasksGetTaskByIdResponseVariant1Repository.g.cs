
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The repository this task belongs to
    /// </summary>
    public sealed partial class AgentTasksGetTaskByIdResponseVariant1Repository
    {
        /// <summary>
        /// The unique identifier of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant1Repository" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByIdResponseVariant1Repository(
            long? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant1Repository" /> class.
        /// </summary>
        public AgentTasksGetTaskByIdResponseVariant1Repository()
        {
        }

    }
}