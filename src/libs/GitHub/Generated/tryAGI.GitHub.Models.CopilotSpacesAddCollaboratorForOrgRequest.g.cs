
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesAddCollaboratorForOrgRequest
    {
        /// <summary>
        /// The type of actor (user or team).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesAddCollaboratorForOrgRequestActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestActorType ActorType { get; set; }

        /// <summary>
        /// The username (for users) or team slug (for teams). The numeric ID of a user or team is also accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorIdentifier { get; set; }

        /// <summary>
        /// The role to grant to the collaborator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesAddCollaboratorForOrgRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesAddCollaboratorForOrgRequest" /> class.
        /// </summary>
        /// <param name="actorType">
        /// The type of actor (user or team).
        /// </param>
        /// <param name="actorIdentifier">
        /// The username (for users) or team slug (for teams). The numeric ID of a user or team is also accepted.
        /// </param>
        /// <param name="role">
        /// The role to grant to the collaborator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesAddCollaboratorForOrgRequest(
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestRole role)
        {
            this.ActorType = actorType;
            this.ActorIdentifier = actorIdentifier ?? throw new global::System.ArgumentNullException(nameof(actorIdentifier));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesAddCollaboratorForOrgRequest" /> class.
        /// </summary>
        public CopilotSpacesAddCollaboratorForOrgRequest()
        {
        }

    }
}