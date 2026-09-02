
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ifNoneMatch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IfNoneMatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3" /> class.
        /// </summary>
        /// <param name="ifNoneMatch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3(
            global::System.Collections.Generic.IList<string> ifNoneMatch)
        {
            this.IfNoneMatch = ifNoneMatch ?? throw new global::System.ArgumentNullException(nameof(ifNoneMatch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3" /> class.
        /// </summary>
        public CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3()
        {
        }

    }
}