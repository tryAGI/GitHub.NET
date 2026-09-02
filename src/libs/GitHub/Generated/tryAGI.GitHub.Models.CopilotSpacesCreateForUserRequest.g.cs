
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesCreateForUserRequest
    {
        /// <summary>
        /// The name of the Copilot Space.<br/>
        /// Example: My Development Space
        /// </summary>
        /// <example>My Development Space</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the Copilot Space.<br/>
        /// Example: Personal space for development assistance
        /// </summary>
        /// <example>Personal space for development assistance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help me with React development patterns and best practices
        /// </summary>
        /// <example>Help me with React development patterns and best practices</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("general_instructions")]
        public string? GeneralInstructions { get; set; }

        /// <summary>
        /// The base role that determines default permissions for the space.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Makes the space publicly readable<br/>
        /// Note: User spaces do not support writer or admin base roles.<br/>
        /// Default Value: no_access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesCreateForUserRequestBaseRoleJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestBaseRole? BaseRole { get; set; }

        /// <summary>
        /// Resources to attach to the space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources_attributes")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttribute>? ResourcesAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: My Development Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Personal space for development assistance
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help me with React development patterns and best practices
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for the space.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Makes the space publicly readable<br/>
        /// Note: User spaces do not support writer or admin base roles.<br/>
        /// Default Value: no_access
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesCreateForUserRequest(
            string name,
            string? description,
            string? generalInstructions,
            global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestBaseRole? baseRole,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttribute>? resourcesAttributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.GeneralInstructions = generalInstructions;
            this.BaseRole = baseRole;
            this.ResourcesAttributes = resourcesAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForUserRequest" /> class.
        /// </summary>
        public CopilotSpacesCreateForUserRequest()
        {
        }

    }
}