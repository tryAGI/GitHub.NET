
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A resource attached to a Copilot Space.
    /// </summary>
    public sealed partial class CopilotSpaceResource
    {
        /// <summary>
        /// The unique identifier of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceResourceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpaceResourceResourceType ResourceType { get; set; }

        /// <summary>
        /// The ID of the associated chat attachment, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_chat_attachment_id")]
        public int? CopilotChatAttachmentId { get; set; }

        /// <summary>
        /// Resource-specific metadata. The keys and values depend on the resource type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The date and time the resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the resource.
        /// </param>
        /// <param name="resourceType">
        /// The type of the resource.
        /// </param>
        /// <param name="metadata">
        /// Resource-specific metadata. The keys and values depend on the resource type.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the resource was last updated.
        /// </param>
        /// <param name="copilotChatAttachmentId">
        /// The ID of the associated chat attachment, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpaceResource(
            int id,
            global::tryAGI.GitHub.CopilotSpaceResourceResourceType resourceType,
            object metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? copilotChatAttachmentId)
        {
            this.Id = id;
            this.ResourceType = resourceType;
            this.CopilotChatAttachmentId = copilotChatAttachmentId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResource" /> class.
        /// </summary>
        public CopilotSpaceResource()
        {
        }

    }
}