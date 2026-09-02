
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A single validation error
    /// </summary>
    public sealed partial class AgentTasksGetTaskByIdResponseError2
    {
        /// <summary>
        /// Machine-readable error code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AgentTasksGetTaskByIdResponseErrorCode2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseErrorCode2 Code { get; set; }

        /// <summary>
        /// Human-readable message (populated when code is "custom")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseError2" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable error code
        /// </param>
        /// <param name="message">
        /// Human-readable message (populated when code is "custom")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByIdResponseError2(
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseErrorCode2 code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseError2" /> class.
        /// </summary>
        public AgentTasksGetTaskByIdResponseError2()
        {
        }

    }
}