
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesUpdateResourceForUserRequest
    {
        /// <summary>
        /// Updated resource-specific metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateResourceForUserRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Updated resource-specific metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesUpdateResourceForUserRequest(
            object? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateResourceForUserRequest" /> class.
        /// </summary>
        public CopilotSpacesUpdateResourceForUserRequest()
        {
        }

    }
}