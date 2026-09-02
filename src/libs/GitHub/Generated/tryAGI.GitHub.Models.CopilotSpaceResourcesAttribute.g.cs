
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpaceResourcesAttribute
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceResourcesAttributeResourceTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpaceResourcesAttributeResourceType? ResourceType { get; set; }

        /// <summary>
        /// The unique identifier of the chat attachment for uploaded files or media content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_chat_attachment_id")]
        public long? CopilotChatAttachmentId { get; set; }

        /// <summary>
        /// The date and time the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Metadata specific to the resource type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::tryAGI.GitHub.CopilotSpaceResourcesAttributeMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResourcesAttribute" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the resource.
        /// </param>
        /// <param name="resourceType">
        /// The type of resource.
        /// </param>
        /// <param name="copilotChatAttachmentId">
        /// The unique identifier of the chat attachment for uploaded files or media content.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the resource was last updated.
        /// </param>
        /// <param name="metadata">
        /// Metadata specific to the resource type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpaceResourcesAttribute(
            long? id,
            global::tryAGI.GitHub.CopilotSpaceResourcesAttributeResourceType? resourceType,
            long? copilotChatAttachmentId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::tryAGI.GitHub.CopilotSpaceResourcesAttributeMetadata? metadata)
        {
            this.Id = id;
            this.ResourceType = resourceType;
            this.CopilotChatAttachmentId = copilotChatAttachmentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResourcesAttribute" /> class.
        /// </summary>
        public CopilotSpaceResourcesAttribute()
        {
        }

    }
}