
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpacesUpdateForOrgRequestResourcesAttribute
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType? ResourceType { get; set; }

        /// <summary>
        /// Metadata specific to the resource type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequestResourcesAttribute" /> class.
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
        public CopilotSpacesUpdateForOrgRequestResourcesAttribute(
            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType? resourceType,
            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata? metadata)
        {
            this.ResourceType = resourceType;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequestResourcesAttribute" /> class.
        /// </summary>
        public CopilotSpacesUpdateForOrgRequestResourcesAttribute()
        {
        }

    }
}