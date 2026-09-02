
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesCreateForOrgRequest
    {
        /// <summary>
        /// The name of the Copilot Space.<br/>
        /// Example: Team Planning Space
        /// </summary>
        /// <example>Team Planning Space</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the Copilot Space.<br/>
        /// Example: Organization space for team planning and coordination
        /// </summary>
        /// <example>Organization space for team planning and coordination</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help the team with planning and coordination tasks
        /// </summary>
        /// <example>Help the team with planning and coordination tasks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("general_instructions")]
        public string? GeneralInstructions { get; set; }

        /// <summary>
        /// The base role that determines default permissions for organization members.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space<br/>
        /// Default Value: no_access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesCreateForOrgRequestBaseRoleJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestBaseRole? BaseRole { get; set; }

        /// <summary>
        /// Resources to attach to the space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources_attributes")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestResourcesAttribute>? ResourcesAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: Team Planning Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Organization space for team planning and coordination
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help the team with planning and coordination tasks
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for organization members.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space<br/>
        /// Default Value: no_access
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesCreateForOrgRequest(
            string name,
            string? description,
            string? generalInstructions,
            global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestBaseRole? baseRole,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestResourcesAttribute>? resourcesAttributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.GeneralInstructions = generalInstructions;
            this.BaseRole = baseRole;
            this.ResourcesAttributes = resourcesAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForOrgRequest" /> class.
        /// </summary>
        public CopilotSpacesCreateForOrgRequest()
        {
        }

    }
}