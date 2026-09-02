
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Structured error response following GitHub REST API conventions.<br/>
    /// For 422 Unprocessable Entity the errors array contains validation<br/>
    /// details; for other error status codes only message and<br/>
    /// documentation_url are returned.
    /// </summary>
    public sealed partial class AgentTasksListTasksForRepoResponse5
    {
        /// <summary>
        /// Summary message (e.g. "Validation Failed", "Not Found")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// List of validation errors (present only for 422 responses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksListTasksForRepoResponseError4>? Errors { get; set; }

        /// <summary>
        /// URL to relevant API documentation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksListTasksForRepoResponse5" /> class.
        /// </summary>
        /// <param name="message">
        /// Summary message (e.g. "Validation Failed", "Not Found")
        /// </param>
        /// <param name="documentationUrl">
        /// URL to relevant API documentation
        /// </param>
        /// <param name="errors">
        /// List of validation errors (present only for 422 responses)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksListTasksForRepoResponse5(
            string message,
            string documentationUrl,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksListTasksForRepoResponseError4>? errors)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Errors = errors;
            this.DocumentationUrl = documentationUrl ?? throw new global::System.ArgumentNullException(nameof(documentationUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksListTasksForRepoResponse5" /> class.
        /// </summary>
        public AgentTasksListTasksForRepoResponse5()
        {
        }

    }
}