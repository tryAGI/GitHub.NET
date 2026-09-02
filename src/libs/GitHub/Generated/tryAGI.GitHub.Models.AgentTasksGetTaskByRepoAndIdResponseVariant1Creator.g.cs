
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A GitHub user
    /// </summary>
    public sealed partial class AgentTasksGetTaskByRepoAndIdResponseVariant1Creator
    {
        /// <summary>
        /// The unique identifier of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant1Creator" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByRepoAndIdResponseVariant1Creator(
            long? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant1Creator" /> class.
        /// </summary>
        public AgentTasksGetTaskByRepoAndIdResponseVariant1Creator()
        {
        }

    }
}