
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesUpdateForOrgRequest
    {
        /// <summary>
        /// The name of the Copilot Space.<br/>
        /// Example: Updated Team Planning Space
        /// </summary>
        /// <example>Updated Team Planning Space</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the Copilot Space.<br/>
        /// Example: Updated organization space for team planning and coordination
        /// </summary>
        /// <example>Updated organization space for team planning and coordination</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// General instructions for the Copilot Space.<br/>
        /// Example: Updated instructions to help the team with planning and coordination tasks
        /// </summary>
        /// <example>Updated instructions to help the team with planning and coordination tasks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("general_instructions")]
        public string? GeneralInstructions { get; set; }

        /// <summary>
        /// The base role that determines default permissions for organization members. Changing this field requires admin permissions.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesUpdateForOrgRequestBaseRoleJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestBaseRole? BaseRole { get; set; }

        /// <summary>
        /// Resources to attach to the space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources_attributes")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttribute>? ResourcesAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: Updated Team Planning Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Updated organization space for team planning and coordination
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Updated instructions to help the team with planning and coordination tasks
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for organization members. Changing this field requires admin permissions.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesUpdateForOrgRequest(
            string? name,
            string? description,
            string? generalInstructions,
            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestBaseRole? baseRole,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttribute>? resourcesAttributes)
        {
            this.Name = name;
            this.Description = description;
            this.GeneralInstructions = generalInstructions;
            this.BaseRole = baseRole;
            this.ResourcesAttributes = resourcesAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequest" /> class.
        /// </summary>
        public CopilotSpacesUpdateForOrgRequest()
        {
        }

    }
}