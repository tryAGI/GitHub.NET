
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsCreateViewForUserRequest
    {
        /// <summary>
        /// The name of the view.<br/>
        /// Example: Sprint Board
        /// </summary>
        /// <example>Sprint Board</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The layout of the view.<br/>
        /// Example: board
        /// </summary>
        /// <example>board</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsCreateViewForUserRequestLayoutJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsCreateViewForUserRequestLayout Layout { get; set; }

        /// <summary>
        /// The filter query for the view. See [Filtering projects](https://docs.github.com/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/filtering-projects) for more information.<br/>
        /// Example: is:issue is:open
        /// </summary>
        /// <example>is:issue is:open</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// `visible_fields` is not applicable to `roadmap` layout views.<br/>
        /// For `table` and `board` layouts, this represents the field IDs that should be visible in the view. If not provided, the default visible fields will be used.<br/>
        /// Example: [123, 456, 789]
        /// </summary>
        /// <example>[123, 456, 789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_fields")]
        public global::System.Collections.Generic.IList<int>? VisibleFields { get; set; }

        /// <summary>
        /// Sorting configuration for the view. Each element is a two-element array of `[field_id, direction]` where `direction` is `"asc"` or `"desc"`. Supports multiple sort criteria applied in order.<br/>
        /// Example: [[123, asc], [456, desc]]
        /// </summary>
        /// <example>[[123, asc], [456, desc]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<int?, string>>>? SortBy { get; set; }

        /// <summary>
        /// The field IDs to group items by (horizontal grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [123]
        /// </summary>
        /// <example>[123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<int>? GroupBy { get; set; }

        /// <summary>
        /// The field IDs to use as columns in `board` layout (vertical grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [456]
        /// </summary>
        /// <example>[456]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_group_by")]
        public global::System.Collections.Generic.IList<int>? VerticalGroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateViewForUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the view.<br/>
        /// Example: Sprint Board
        /// </param>
        /// <param name="layout">
        /// The layout of the view.<br/>
        /// Example: board
        /// </param>
        /// <param name="filter">
        /// The filter query for the view. See [Filtering projects](https://docs.github.com/issues/planning-and-tracking-with-projects/customizing-views-in-your-project/filtering-projects) for more information.<br/>
        /// Example: is:issue is:open
        /// </param>
        /// <param name="visibleFields">
        /// `visible_fields` is not applicable to `roadmap` layout views.<br/>
        /// For `table` and `board` layouts, this represents the field IDs that should be visible in the view. If not provided, the default visible fields will be used.<br/>
        /// Example: [123, 456, 789]
        /// </param>
        /// <param name="sortBy">
        /// Sorting configuration for the view. Each element is a two-element array of `[field_id, direction]` where `direction` is `"asc"` or `"desc"`. Supports multiple sort criteria applied in order.<br/>
        /// Example: [[123, asc], [456, desc]]
        /// </param>
        /// <param name="groupBy">
        /// The field IDs to group items by (horizontal grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [123]
        /// </param>
        /// <param name="verticalGroupBy">
        /// The field IDs to use as columns in `board` layout (vertical grouping). Supports a single field. The field must support grouping; fields such as `Title`, `Reviewers`, `Linked pull requests`, `Sub-issues progress`, `Tracked by`, and `Tracks` cannot be grouped on.<br/>
        /// Example: [456]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateViewForUserRequest(
            string name,
            global::tryAGI.GitHub.ProjectsCreateViewForUserRequestLayout layout,
            string? filter,
            global::System.Collections.Generic.IList<int>? visibleFields,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<int?, string>>>? sortBy,
            global::System.Collections.Generic.IList<int>? groupBy,
            global::System.Collections.Generic.IList<int>? verticalGroupBy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Layout = layout;
            this.Filter = filter;
            this.VisibleFields = visibleFields;
            this.SortBy = sortBy;
            this.GroupBy = groupBy;
            this.VerticalGroupBy = verticalGroupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateViewForUserRequest" /> class.
        /// </summary>
        public ProjectsCreateViewForUserRequest()
        {
        }

    }
}