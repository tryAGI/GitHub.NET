
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A projects v2 project
    /// </summary>
    public sealed partial class ProjectsV2
    {
        /// <summary>
        /// The unique identifier of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// The node ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Owner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Creator { get; set; }

        /// <summary>
        /// The project title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A short description of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the project is visible to anyone with access to the owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// The time when the project was closed.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// The time when the project was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the project was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The project number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// A concise summary of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// The time when the project was deleted.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by")]
        public global::tryAGI.GitHub.NullableSimpleUser? DeletedBy { get; set; }

        /// <summary>
        /// The current state of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsV2StateJsonConverter))]
        public global::tryAGI.GitHub.ProjectsV2State? State { get; set; }

        /// <summary>
        /// An status update belonging to a project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_status_update")]
        public global::tryAGI.GitHub.NullableProjectsV2StatusUpdate? LatestStatusUpdate { get; set; }

        /// <summary>
        /// Whether this project is a template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_template")]
        public bool? IsTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the project.
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the project.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="title">
        /// The project title.
        /// </param>
        /// <param name="public">
        /// Whether the project is visible to anyone with access to the owner.
        /// </param>
        /// <param name="createdAt">
        /// The time when the project was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// The time when the project was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="number">
        /// The project number.
        /// </param>
        /// <param name="description">
        /// A short description of the project.
        /// </param>
        /// <param name="closedAt">
        /// The time when the project was closed.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="shortDescription">
        /// A concise summary of the project.
        /// </param>
        /// <param name="deletedAt">
        /// The time when the project was deleted.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="deletedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="state">
        /// The current state of the project.
        /// </param>
        /// <param name="latestStatusUpdate">
        /// An status update belonging to a project
        /// </param>
        /// <param name="isTemplate">
        /// Whether this project is a template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2(
            double id,
            string nodeId,
            global::tryAGI.GitHub.SimpleUser owner,
            global::tryAGI.GitHub.SimpleUser creator,
            string title,
            bool @public,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int number,
            string? description,
            global::System.DateTime? closedAt,
            string? shortDescription,
            global::System.DateTime? deletedAt,
            global::tryAGI.GitHub.NullableSimpleUser? deletedBy,
            global::tryAGI.GitHub.ProjectsV2State? state,
            global::tryAGI.GitHub.NullableProjectsV2StatusUpdate? latestStatusUpdate,
            bool? isTemplate)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.Public = @public;
            this.ClosedAt = closedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Number = number;
            this.ShortDescription = shortDescription;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.State = state;
            this.LatestStatusUpdate = latestStatusUpdate;
            this.IsTemplate = isTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2" /> class.
        /// </summary>
        public ProjectsV2()
        {
        }

    }
}