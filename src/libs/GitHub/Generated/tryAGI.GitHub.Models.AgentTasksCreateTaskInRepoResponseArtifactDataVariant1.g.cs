
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A GitHub resource (pull request, issue, etc.)
    /// </summary>
    public sealed partial class AgentTasksCreateTaskInRepoResponseArtifactDataVariant1
    {
        /// <summary>
        /// GitHub resource ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// GraphQL global ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_id")]
        public string? GlobalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoResponseArtifactDataVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// GitHub resource ID
        /// </param>
        /// <param name="globalId">
        /// GraphQL global ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksCreateTaskInRepoResponseArtifactDataVariant1(
            long id,
            string? globalId)
        {
            this.Id = id;
            this.GlobalId = globalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoResponseArtifactDataVariant1" /> class.
        /// </summary>
        public AgentTasksCreateTaskInRepoResponseArtifactDataVariant1()
        {
        }

    }
}