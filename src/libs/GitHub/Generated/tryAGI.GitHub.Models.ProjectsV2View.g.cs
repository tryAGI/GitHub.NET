
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A view inside a projects v2 project
    /// </summary>
    public sealed partial class ProjectsV2View
    {
        /// <summary>
        /// The unique identifier of the view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The number of the view within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The name of the view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The layout of the view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsV2ViewLayoutJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsV2ViewLayout Layout { get; set; }

        /// <summary>
        /// The node ID of the view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The API URL of the project that contains the view.<br/>
        /// Example: https://api.github.com/orgs/octocat/projectsV2/1
        /// </summary>
        /// <example>https://api.github.com/orgs/octocat/projectsV2/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// The web URL of the view.<br/>
        /// Example: https://github.com/orgs/octocat/projects/1/views/1
        /// </summary>
        /// <example>https://github.com/orgs/octocat/projects/1/views/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Creator { get; set; }

        /// <summary>
        /// The time when the view was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time when the view was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The filter query for the view.<br/>
        /// Example: is:issue is:open
        /// </summary>
        /// <example>is:issue is:open</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// The list of field IDs that are visible in the view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> VisibleFields { get; set; }

        /// <summary>
        /// The sorting configuration for the view. Each element is a tuple of [field_id, direction] where direction is "asc" or "desc".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<int?, string>>> SortBy { get; set; }

        /// <summary>
        /// The list of field IDs used for horizontal grouping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> GroupBy { get; set; }

        /// <summary>
        /// The list of field IDs used for vertical grouping (board layout).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> VerticalGroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2View" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the view.
        /// </param>
        /// <param name="number">
        /// The number of the view within the project.
        /// </param>
        /// <param name="name">
        /// The name of the view.
        /// </param>
        /// <param name="layout">
        /// The layout of the view.
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the view.
        /// </param>
        /// <param name="projectUrl">
        /// The API URL of the project that contains the view.<br/>
        /// Example: https://api.github.com/orgs/octocat/projectsV2/1
        /// </param>
        /// <param name="htmlUrl">
        /// The web URL of the view.<br/>
        /// Example: https://github.com/orgs/octocat/projects/1/views/1
        /// </param>
        /// <param name="creator"></param>
        /// <param name="createdAt">
        /// The time when the view was created.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// The time when the view was last updated.<br/>
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="visibleFields">
        /// The list of field IDs that are visible in the view.
        /// </param>
        /// <param name="sortBy">
        /// The sorting configuration for the view. Each element is a tuple of [field_id, direction] where direction is "asc" or "desc".
        /// </param>
        /// <param name="groupBy">
        /// The list of field IDs used for horizontal grouping.
        /// </param>
        /// <param name="verticalGroupBy">
        /// The list of field IDs used for vertical grouping (board layout).
        /// </param>
        /// <param name="filter">
        /// The filter query for the view.<br/>
        /// Example: is:issue is:open
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2View(
            int id,
            int number,
            string name,
            global::tryAGI.GitHub.ProjectsV2ViewLayout layout,
            string nodeId,
            string projectUrl,
            string htmlUrl,
            global::tryAGI.GitHub.SimpleUser creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<int> visibleFields,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<int?, string>>> sortBy,
            global::System.Collections.Generic.IList<int> groupBy,
            global::System.Collections.Generic.IList<int> verticalGroupBy,
            string? filter)
        {
            this.Id = id;
            this.Number = number;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Layout = layout;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Filter = filter;
            this.VisibleFields = visibleFields ?? throw new global::System.ArgumentNullException(nameof(visibleFields));
            this.SortBy = sortBy ?? throw new global::System.ArgumentNullException(nameof(sortBy));
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.VerticalGroupBy = verticalGroupBy ?? throw new global::System.ArgumentNullException(nameof(verticalGroupBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2View" /> class.
        /// </summary>
        public ProjectsV2View()
        {
        }

    }
}