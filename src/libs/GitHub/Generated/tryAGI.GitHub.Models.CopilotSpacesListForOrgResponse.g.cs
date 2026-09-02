
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesListForOrgResponse
    {
        /// <summary>
        /// The list of Copilot Spaces on this page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpace> Spaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListForOrgResponse" /> class.
        /// </summary>
        /// <param name="spaces">
        /// The list of Copilot Spaces on this page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesListForOrgResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpace> spaces)
        {
            this.Spaces = spaces ?? throw new global::System.ArgumentNullException(nameof(spaces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesListForOrgResponse" /> class.
        /// </summary>
        public CopilotSpacesListForOrgResponse()
        {
        }

    }
}