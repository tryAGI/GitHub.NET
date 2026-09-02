
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Error details for a failed session
    /// </summary>
    public sealed partial class AgentTasksGetTaskByRepoAndIdResponseVariant2SessionError
    {
        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2SessionError" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByRepoAndIdResponseVariant2SessionError(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2SessionError" /> class.
        /// </summary>
        public AgentTasksGetTaskByRepoAndIdResponseVariant2SessionError()
        {
        }

    }
}