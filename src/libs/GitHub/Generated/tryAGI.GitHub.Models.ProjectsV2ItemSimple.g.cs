
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// An item belonging to a project
    /// </summary>
    public sealed partial class ProjectsV2ItemSimple
    {
        /// <summary>
        /// The unique identifier of the project item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// The node ID of the project item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The content represented by the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.Issue, global::tryAGI.GitHub.PullRequestSimple, global::tryAGI.GitHub.ProjectsV2DraftIssue>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.Issue, global::tryAGI.GitHub.PullRequestSimple, global::tryAGI.GitHub.ProjectsV2DraftIssue>? Content { get; set; }

        /// <summary>
        /// The type of content tracked in a project item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsV2ItemContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsV2ItemContentType ContentType { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::tryAGI.GitHub.SimpleUser? Creator { get; set; }

        /// <summary>
        /// The time when the item was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the item was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The time when the item was archived.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// The URL of the project this item belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        public string? ProjectUrl { get; set; }

        /// <summary>
        /// The URL of the item in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_url")]
        public string? ItemUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2ItemSimple" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the project item.
        /// </param>
        /// <param name="contentType">
        /// The type of content tracked in a project item
        /// </param>
        /// <param name="createdAt">
        /// The time when the item was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// The time when the item was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the project item.
        /// </param>
        /// <param name="content">
        /// The content represented by the item.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="archivedAt">
        /// The time when the item was archived.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="projectUrl">
        /// The URL of the project this item belongs to.
        /// </param>
        /// <param name="itemUrl">
        /// The URL of the item in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2ItemSimple(
            double id,
            global::tryAGI.GitHub.ProjectsV2ItemContentType contentType,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? nodeId,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.Issue, global::tryAGI.GitHub.PullRequestSimple, global::tryAGI.GitHub.ProjectsV2DraftIssue>? content,
            global::tryAGI.GitHub.SimpleUser? creator,
            global::System.DateTime? archivedAt,
            string? projectUrl,
            string? itemUrl)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Content = content;
            this.ContentType = contentType;
            this.Creator = creator;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.ProjectUrl = projectUrl;
            this.ItemUrl = itemUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2ItemSimple" /> class.
        /// </summary>
        public ProjectsV2ItemSimple()
        {
        }

    }
}