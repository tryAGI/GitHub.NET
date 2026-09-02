
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Organization roles
    /// </summary>
    public sealed partial class OrganizationRole
    {
        /// <summary>
        /// The unique identifier of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short description about who this role is for or what permissions it grants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The system role from which this role inherits permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationRoleBaseRoleJsonConverter))]
        public global::tryAGI.GitHub.OrganizationRoleBaseRole? BaseRole { get; set; }

        /// <summary>
        /// Source answers the question, "where did this role come from?"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationRoleSourceJsonConverter))]
        public global::tryAGI.GitHub.OrganizationRoleSource? Source { get; set; }

        /// <summary>
        /// A list of permissions included in this role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::tryAGI.GitHub.NullableSimpleUser? Organization { get; set; }

        /// <summary>
        /// The date and time the role was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the role was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the role.
        /// </param>
        /// <param name="name">
        /// The name of the role.
        /// </param>
        /// <param name="permissions">
        /// A list of permissions included in this role.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the role was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the role was last updated.
        /// </param>
        /// <param name="description">
        /// A short description about who this role is for or what permissions it grants.
        /// </param>
        /// <param name="baseRole">
        /// The system role from which this role inherits permissions.
        /// </param>
        /// <param name="source">
        /// Source answers the question, "where did this role come from?"
        /// </param>
        /// <param name="organization">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationRole(
            long id,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::tryAGI.GitHub.OrganizationRoleBaseRole? baseRole,
            global::tryAGI.GitHub.OrganizationRoleSource? source,
            global::tryAGI.GitHub.NullableSimpleUser? organization)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.BaseRole = baseRole;
            this.Source = source;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Organization = organization;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        public OrganizationRole()
        {
        }

    }
}