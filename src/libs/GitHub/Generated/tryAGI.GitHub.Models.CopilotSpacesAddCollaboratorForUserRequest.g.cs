
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesAddCollaboratorForUserRequest
    {
        /// <summary>
        /// The type of actor (must be `User` for user-owned spaces; `Team` will be rejected).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesAddCollaboratorForUserRequestActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestActorType ActorType { get; set; }

        /// <summary>
        /// The username of the collaborator. The numeric user ID is also accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorIdentifier { get; set; }

        /// <summary>
        /// The role to grant to the collaborator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesAddCollaboratorForUserRequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesAddCollaboratorForUserRequest" /> class.
        /// </summary>
        /// <param name="actorType">
        /// The type of actor (must be `User` for user-owned spaces; `Team` will be rejected).
        /// </param>
        /// <param name="actorIdentifier">
        /// The username of the collaborator. The numeric user ID is also accepted.
        /// </param>
        /// <param name="role">
        /// The role to grant to the collaborator.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesAddCollaboratorForUserRequest(
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestRole role)
        {
            this.ActorType = actorType;
            this.ActorIdentifier = actorIdentifier ?? throw new global::System.ArgumentNullException(nameof(actorIdentifier));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesAddCollaboratorForUserRequest" /> class.
        /// </summary>
        public CopilotSpacesAddCollaboratorForUserRequest()
        {
        }

    }
}