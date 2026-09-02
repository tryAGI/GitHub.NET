
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A custom attribute defined at the organization level for attaching structured data to issues.
    /// </summary>
    public sealed partial class IssueField
    {
        /// <summary>
        /// The unique identifier of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The node identifier of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The data type of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueFieldDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.IssueFieldDataType DataType { get; set; }

        /// <summary>
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueFieldVisibilityJsonConverter))]
        public global::tryAGI.GitHub.IssueFieldVisibility? Visibility { get; set; }

        /// <summary>
        /// Available options for single select and multi select fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldOption>? Options { get; set; }

        /// <summary>
        /// The time the issue field was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time the issue field was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueField" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue field.
        /// </param>
        /// <param name="nodeId">
        /// The node identifier of the issue field.
        /// </param>
        /// <param name="name">
        /// The name of the issue field.
        /// </param>
        /// <param name="dataType">
        /// The data type of the issue field.
        /// </param>
        /// <param name="description">
        /// The description of the issue field.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues).
        /// </param>
        /// <param name="options">
        /// Available options for single select and multi select fields.
        /// </param>
        /// <param name="createdAt">
        /// The time the issue field was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time the issue field was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueField(
            int id,
            string nodeId,
            string name,
            global::tryAGI.GitHub.IssueFieldDataType dataType,
            string? description,
            global::tryAGI.GitHub.IssueFieldVisibility? visibility,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldOption>? options,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DataType = dataType;
            this.Visibility = visibility;
            this.Options = options;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueField" /> class.
        /// </summary>
        public IssueField()
        {
        }

    }
}