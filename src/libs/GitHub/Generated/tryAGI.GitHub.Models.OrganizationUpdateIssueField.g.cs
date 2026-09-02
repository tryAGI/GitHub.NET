
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationUpdateIssueField
    {
        /// <summary>
        /// Name of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationUpdateIssueFieldVisibilityJsonConverter))]
        public global::tryAGI.GitHub.OrganizationUpdateIssueFieldVisibility? Visibility { get; set; }

        /// <summary>
        /// Options for select fields. Only applicable when updating single_select or multi_select fields. When provided, this array **replaces** the entire existing set of options rather than adding to or updating individual options. To retain or update an existing option, include it in the array with its `id`. Options sent without an `id` are treated as new options and may cause existing options to be deleted and recreated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationUpdateIssueFieldOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateIssueField" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the issue field.
        /// </param>
        /// <param name="description">
        /// Description of the issue field.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled.
        /// </param>
        /// <param name="options">
        /// Options for select fields. Only applicable when updating single_select or multi_select fields. When provided, this array **replaces** the entire existing set of options rather than adding to or updating individual options. To retain or update an existing option, include it in the array with its `id`. Options sent without an `id` are treated as new options and may cause existing options to be deleted and recreated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUpdateIssueField(
            string? name,
            string? description,
            global::tryAGI.GitHub.OrganizationUpdateIssueFieldVisibility? visibility,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationUpdateIssueFieldOption>? options)
        {
            this.Name = name;
            this.Description = description;
            this.Visibility = visibility;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateIssueField" /> class.
        /// </summary>
        public OrganizationUpdateIssueField()
        {
        }

    }
}