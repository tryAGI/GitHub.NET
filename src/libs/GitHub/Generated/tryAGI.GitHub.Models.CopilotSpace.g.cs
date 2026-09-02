
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A GitHub Copilot Space represents an interactive AI workspace where users can ask questions and get assistance.
    /// </summary>
    public sealed partial class CopilotSpace
    {
        /// <summary>
        /// The unique identifier of the space.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The number that identifies the space within its owner.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The display name of the space.<br/>
        /// Example: My Development Space
        /// </summary>
        /// <example>My Development Space</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the space.<br/>
        /// Example: A space for discussing React development patterns
        /// </summary>
        /// <example>A space for discussing React development patterns</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help with React development patterns and best practices
        /// </summary>
        /// <example>Help with React development patterns and best practices</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("general_instructions")]
        public string? GeneralInstructions { get; set; }

        /// <summary>
        /// The base role that determines default permissions.<br/>
        /// - `no_access`: No default access<br/>
        /// - `reader`: Default read permissions<br/>
        /// - `writer`: Default write permissions (organization spaces only)<br/>
        /// - `admin`: Default admin permissions (organization spaces only)<br/>
        /// Example: no_access
        /// </summary>
        /// <example>no_access</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceBaseRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpaceBaseRole BaseRole { get; set; }

        /// <summary>
        /// The user or organization that owns this space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AnyOfJsonConverter<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.OrganizationSimple>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.OrganizationSimple> Owner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Creator { get; set; }

        /// <summary>
        /// The date and time the space was created.<br/>
        /// Example: 2023-01-01T00:00:00Z
        /// </summary>
        /// <example>2023-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the space was last updated.<br/>
        /// Example: 2023-01-01T12:00:00Z
        /// </summary>
        /// <example>2023-01-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The HTML URL of the space.<br/>
        /// Example: https://github.com/copilot/spaces/octo-org/5
        /// </summary>
        /// <example>https://github.com/copilot/spaces/octo-org/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The API URL of the space.<br/>
        /// Example: https://api.github.com/organizations/1/copilot-spaces/5
        /// </summary>
        /// <example>https://api.github.com/organizations/1/copilot-spaces/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUrl { get; set; }

        /// <summary>
        /// Resources attached to the space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources_attributes")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceResourcesAttribute>? ResourcesAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpace" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the space.<br/>
        /// Example: 42
        /// </param>
        /// <param name="number">
        /// The number that identifies the space within its owner.<br/>
        /// Example: 1
        /// </param>
        /// <param name="name">
        /// The display name of the space.<br/>
        /// Example: My Development Space
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions.<br/>
        /// - `no_access`: No default access<br/>
        /// - `reader`: Default read permissions<br/>
        /// - `writer`: Default write permissions (organization spaces only)<br/>
        /// - `admin`: Default admin permissions (organization spaces only)<br/>
        /// Example: no_access
        /// </param>
        /// <param name="owner">
        /// The user or organization that owns this space.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the space was created.<br/>
        /// Example: 2023-01-01T00:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the space was last updated.<br/>
        /// Example: 2023-01-01T12:00:00Z
        /// </param>
        /// <param name="htmlUrl">
        /// The HTML URL of the space.<br/>
        /// Example: https://github.com/copilot/spaces/octo-org/5
        /// </param>
        /// <param name="apiUrl">
        /// The API URL of the space.<br/>
        /// Example: https://api.github.com/organizations/1/copilot-spaces/5
        /// </param>
        /// <param name="description">
        /// A description of the space.<br/>
        /// Example: A space for discussing React development patterns
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help with React development patterns and best practices
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources attached to the space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpace(
            long id,
            int number,
            string name,
            global::tryAGI.GitHub.CopilotSpaceBaseRole baseRole,
            global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.OrganizationSimple> owner,
            global::tryAGI.GitHub.SimpleUser creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string htmlUrl,
            string apiUrl,
            string? description,
            string? generalInstructions,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceResourcesAttribute>? resourcesAttributes)
        {
            this.Id = id;
            this.Number = number;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.GeneralInstructions = generalInstructions;
            this.BaseRole = baseRole;
            this.Owner = owner;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.ResourcesAttributes = resourcesAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpace" /> class.
        /// </summary>
        public CopilotSpace()
        {
        }

    }
}