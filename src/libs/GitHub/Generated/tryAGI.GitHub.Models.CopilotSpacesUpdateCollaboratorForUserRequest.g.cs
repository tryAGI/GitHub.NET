
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesUpdateCollaboratorForUserRequest
    {
        /// <summary>
        /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesUpdateCollaboratorForUserRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateCollaboratorForUserRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesUpdateCollaboratorForUserRequest(
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserRequestRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateCollaboratorForUserRequest" /> class.
        /// </summary>
        public CopilotSpacesUpdateCollaboratorForUserRequest()
        {
        }

    }
}