
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Custom agent metadata associated with this task
    /// </summary>
    public sealed partial class AgentTasksGetTaskByIdResponseVariant1CustomAgent
    {
        /// <summary>
        /// The custom agent's filename without the extension - for example, `performance-optimizer` for a `.github/agents/performance-optimizer.agent.md` custom agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant1CustomAgent" /> class.
        /// </summary>
        /// <param name="id">
        /// The custom agent's filename without the extension - for example, `performance-optimizer` for a `.github/agents/performance-optimizer.agent.md` custom agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByIdResponseVariant1CustomAgent(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant1CustomAgent" /> class.
        /// </summary>
        public AgentTasksGetTaskByIdResponseVariant1CustomAgent()
        {
        }

    }
}