
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesCreateResourceForOrgRequest
    {
        /// <summary>
        /// The type of resource to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesCreateResourceForOrgRequestResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpacesCreateResourceForOrgRequestResourceType ResourceType { get; set; }

        /// <summary>
        /// Resource-specific metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateResourceForOrgRequest" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// The type of resource to create.
        /// </param>
        /// <param name="metadata">
        /// Resource-specific metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesCreateResourceForOrgRequest(
            global::tryAGI.GitHub.CopilotSpacesCreateResourceForOrgRequestResourceType resourceType,
            object metadata)
        {
            this.ResourceType = resourceType;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateResourceForOrgRequest" /> class.
        /// </summary>
        public CopilotSpacesCreateResourceForOrgRequest()
        {
        }

    }
}