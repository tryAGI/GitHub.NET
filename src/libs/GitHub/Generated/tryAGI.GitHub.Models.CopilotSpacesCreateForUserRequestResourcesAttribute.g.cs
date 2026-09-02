
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesCreateForUserRequestResourcesAttribute
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesCreateForUserRequestResourcesAttributeResourceTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttributeResourceType? ResourceType { get; set; }

        /// <summary>
        /// Metadata specific to the resource type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttributeMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForUserRequestResourcesAttribute" /> class.
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
        public CopilotSpacesCreateForUserRequestResourcesAttribute(
            global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttributeResourceType? resourceType,
            global::tryAGI.GitHub.CopilotSpacesCreateForUserRequestResourcesAttributeMetadata? metadata)
        {
            this.ResourceType = resourceType;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesCreateForUserRequestResourcesAttribute" /> class.
        /// </summary>
        public CopilotSpacesCreateForUserRequestResourcesAttribute()
        {
        }

    }
}