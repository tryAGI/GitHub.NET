
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTasksGetTaskByRepoAndIdResponseVariant1
    {
        /// <summary>
        /// Unique task identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// API URL for this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Web URL for this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Human-readable name derived from the task prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The entity who created this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Creator? Creator { get; set; }

        /// <summary>
        /// Type of the task creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorTypeJsonConverter))]
        public global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType? CreatorType { get; set; }

        /// <summary>
        /// User objects of collaborators on this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_collaborators")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1UserCollaborator>? UserCollaborators { get; set; }

        /// <summary>
        /// The owner of the repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Owner? Owner { get; set; }

        /// <summary>
        /// The repository this task belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Repository? Repository { get; set; }

        /// <summary>
        /// Current state of the task, derived from its most recent session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AgentTasksGetTaskByRepoAndIdResponseVariant1StateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1State State { get; set; }

        /// <summary>
        /// Number of sessions in this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_count")]
        public int? SessionCount { get; set; }

        /// <summary>
        /// Resources created by this task (PRs, branches, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Artifact>? Artifacts { get; set; }

        /// <summary>
        /// Timestamp when the task was archived, null if not archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Timestamp of the most recent update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp when the task was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Custom agent metadata associated with this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_agent")]
        public global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1CustomAgent? CustomAgent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique task identifier
        /// </param>
        /// <param name="state">
        /// Current state of the task, derived from its most recent session
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the task was created
        /// </param>
        /// <param name="url">
        /// API URL for this task
        /// </param>
        /// <param name="htmlUrl">
        /// Web URL for this task
        /// </param>
        /// <param name="name">
        /// Human-readable name derived from the task prompt
        /// </param>
        /// <param name="creator">
        /// The entity who created this task
        /// </param>
        /// <param name="creatorType">
        /// Type of the task creator
        /// </param>
        /// <param name="owner">
        /// The owner of the repository
        /// </param>
        /// <param name="repository">
        /// The repository this task belongs to
        /// </param>
        /// <param name="sessionCount">
        /// Number of sessions in this task
        /// </param>
        /// <param name="artifacts">
        /// Resources created by this task (PRs, branches, etc.)
        /// </param>
        /// <param name="archivedAt">
        /// Timestamp when the task was archived, null if not archived
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of the most recent update
        /// </param>
        /// <param name="customAgent">
        /// Custom agent metadata associated with this task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByRepoAndIdResponseVariant1(
            string id,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1State state,
            global::System.DateTime createdAt,
            string? url,
            string? htmlUrl,
            string? name,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Creator? creator,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType? creatorType,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Owner? owner,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Repository? repository,
            int? sessionCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1Artifact>? artifacts,
            global::System.DateTime? archivedAt,
            global::System.DateTime? updatedAt,
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant1CustomAgent? customAgent)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Name = name;
            this.Creator = creator;
            this.CreatorType = creatorType;
            this.Owner = owner;
            this.Repository = repository;
            this.State = state;
            this.SessionCount = sessionCount;
            this.Artifacts = artifacts;
            this.ArchivedAt = archivedAt;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.CustomAgent = customAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant1" /> class.
        /// </summary>
        public AgentTasksGetTaskByRepoAndIdResponseVariant1()
        {
        }

    }
}