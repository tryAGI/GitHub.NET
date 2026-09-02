
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesListResourcesForUserResponse
    {
        /// <summary>
        /// The list of resources attached to this Copilot Space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceResource> Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListResourcesForUserResponse" /> class.
        /// </summary>
        /// <param name="resources">
        /// The list of resources attached to this Copilot Space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesListResourcesForUserResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpaceResource> resources)
        {
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListResourcesForUserResponse" /> class.
        /// </summary>
        public CopilotSpacesListResourcesForUserResponse()
        {
        }

    }
}