
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The repository this session belongs to
    /// </summary>
    public sealed partial class AgentTasksGetTaskByIdResponseVariant2SessionRepository
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
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant2SessionRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByIdResponseVariant2SessionRepository(
            long? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant2SessionRepository" /> class.
        /// </summary>
        public AgentTasksGetTaskByIdResponseVariant2SessionRepository()
        {
        }

    }
}