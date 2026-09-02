
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesUpdateForUserRequestResourcesAttribute
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesUpdateForUserRequestResourcesAttributeResourceTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType? ResourceType { get; set; }

        /// <summary>
        /// Metadata specific to the resource type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestResourcesAttributeMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForUserRequestResourcesAttribute" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// The type of resource.
        /// </param>
        /// <param name="metadata">
        /// Metadata specific to the resource type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesUpdateForUserRequestResourcesAttribute(
            global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType? resourceType,
            global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestResourcesAttributeMetadata? metadata)
        {
            this.ResourceType = resourceType;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForUserRequestResourcesAttribute" /> class.
        /// </summary>
        public CopilotSpacesUpdateForUserRequestResourcesAttribute()
        {
        }

    }
}