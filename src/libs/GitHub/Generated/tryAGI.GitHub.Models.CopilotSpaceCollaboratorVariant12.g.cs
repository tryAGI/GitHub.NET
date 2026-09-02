
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpaceCollaboratorVariant12
    {
        /// <summary>
        /// The collaborator actor type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceCollaboratorVariant1ActorTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant1ActorType ActorType { get; set; }

        /// <summary>
        /// The role granted to the collaborator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceCollaboratorVariant1RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant1Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceCollaboratorVariant12" /> class.
        /// </summary>
        /// <param name="role">
        /// The role granted to the collaborator
        /// </param>
        /// <param name="actorType">
        /// The collaborator actor type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpaceCollaboratorVariant12(
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant1Role role,
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant1ActorType actorType)
        {
            this.ActorType = actorType;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceCollaboratorVariant12" /> class.
        /// </summary>
        public CopilotSpaceCollaboratorVariant12()
        {
        }

    }
}