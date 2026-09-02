
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesListCollaboratorsForOrgResponse
    {
        /// <summary>
        /// The list of collaborators for this Copilot Space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceCollaborator> Collaborators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListCollaboratorsForOrgResponse" /> class.
        /// </summary>
        /// <param name="collaborators">
        /// The list of collaborators for this Copilot Space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesListCollaboratorsForOrgResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceCollaborator> collaborators)
        {
            this.Collaborators = collaborators ?? throw new global::System.ArgumentNullException(nameof(collaborators));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListCollaboratorsForOrgResponse" /> class.
        /// </summary>
        public CopilotSpacesListCollaboratorsForOrgResponse()
        {
        }

    }
}