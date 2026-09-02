
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Full session details within a task
    /// </summary>
    public sealed partial class AgentTasksGetTaskByIdResponseVariant2Session
    {
        /// <summary>
        /// Session ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Session name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The user who created this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionUser? User { get; set; }

        /// <summary>
        /// The owner of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionOwner? Owner { get; set; }

        /// <summary>
        /// The repository this session belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionRepository? Repository { get; set; }

        /// <summary>
        /// Task ID this session belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        /// Current state of a session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AgentTasksGetTaskByIdResponseVariant2SessionStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionState State { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Completion timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Content of the triggering event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Head branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_ref")]
        public string? HeadRef { get; set; }

        /// <summary>
        /// Base branch name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        public string? BaseRef { get; set; }

        /// <summary>
        /// Model used for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Structured information about billing units consumed by the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionUsage? Usage { get; set; }

        /// <summary>
        /// Error details for a failed session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant2Session" /> class.
        /// </summary>
        /// <param name="id">
        /// Session ID
        /// </param>
        /// <param name="state">
        /// Current state of a session
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="name">
        /// Session name
        /// </param>
        /// <param name="user">
        /// The user who created this session
        /// </param>
        /// <param name="owner">
        /// The owner of the repository
        /// </param>
        /// <param name="repository">
        /// The repository this session belongs to
        /// </param>
        /// <param name="taskId">
        /// Task ID this session belongs to
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp
        /// </param>
        /// <param name="completedAt">
        /// Completion timestamp
        /// </param>
        /// <param name="prompt">
        /// Content of the triggering event
        /// </param>
        /// <param name="headRef">
        /// Head branch name
        /// </param>
        /// <param name="baseRef">
        /// Base branch name
        /// </param>
        /// <param name="model">
        /// Model used for this session
        /// </param>
        /// <param name="usage">
        /// Structured information about billing units consumed by the session.
        /// </param>
        /// <param name="error">
        /// Error details for a failed session
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByIdResponseVariant2Session(
            string id,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionState state,
            global::System.DateTime createdAt,
            string? name,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionUser? user,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionOwner? owner,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionRepository? repository,
            string? taskId,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            string? prompt,
            string? headRef,
            string? baseRef,
            string? model,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionUsage? usage,
            global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2SessionError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.User = user;
            this.Owner = owner;
            this.Repository = repository;
            this.TaskId = taskId;
            this.State = state;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.Prompt = prompt;
            this.HeadRef = headRef;
            this.BaseRef = baseRef;
            this.Model = model;
            this.Usage = usage;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByIdResponseVariant2Session" /> class.
        /// </summary>
        public AgentTasksGetTaskByIdResponseVariant2Session()
        {
        }

    }
}