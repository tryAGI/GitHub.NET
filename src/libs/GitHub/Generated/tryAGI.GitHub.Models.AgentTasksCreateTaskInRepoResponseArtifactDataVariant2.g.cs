
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A Git branch reference
    /// </summary>
    public sealed partial class AgentTasksCreateTaskInRepoResponseArtifactDataVariant2
    {
        /// <summary>
        /// Head branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadRef { get; set; }

        /// <summary>
        /// Base branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoResponseArtifactDataVariant2" /> class.
        /// </summary>
        /// <param name="headRef">
        /// Head branch name
        /// </param>
        /// <param name="baseRef">
        /// Base branch name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksCreateTaskInRepoResponseArtifactDataVariant2(
            string headRef,
            string baseRef)
        {
            this.HeadRef = headRef ?? throw new global::System.ArgumentNullException(nameof(headRef));
            this.BaseRef = baseRef ?? throw new global::System.ArgumentNullException(nameof(baseRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoResponseArtifactDataVariant2" /> class.
        /// </summary>
        public AgentTasksCreateTaskInRepoResponseArtifactDataVariant2()
        {
        }

    }
}