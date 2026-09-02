
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationCreateIssueField
    {
        /// <summary>
        /// Name of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The data type of the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationCreateIssueFieldDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrganizationCreateIssueFieldDataType DataType { get; set; }

        /// <summary>
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled. Defaults to `organization_members_only`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationCreateIssueFieldVisibilityJsonConverter))]
        public global::tryAGI.GitHub.OrganizationCreateIssueFieldVisibility? Visibility { get; set; }

        /// <summary>
        /// Options for select fields. Required when data_type is 'single_select' or 'multi_select'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationCreateIssueFieldOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueField" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the issue field.
        /// </param>
        /// <param name="dataType">
        /// The data type of the issue field.
        /// </param>
        /// <param name="description">
        /// Description of the issue field.
        /// </param>
        /// <param name="visibility">
        /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled. Defaults to `organization_members_only`.
        /// </param>
        /// <param name="options">
        /// Options for select fields. Required when data_type is 'single_select' or 'multi_select'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreateIssueField(
            string name,
            global::tryAGI.GitHub.OrganizationCreateIssueFieldDataType dataType,
            string? description,
            global::tryAGI.GitHub.OrganizationCreateIssueFieldVisibility? visibility,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationCreateIssueFieldOption>? options)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DataType = dataType;
            this.Visibility = visibility;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueField" /> class.
        /// </summary>
        public OrganizationCreateIssueField()
        {
        }

    }
}