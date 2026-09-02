
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Metadata specific to the resource type.
    /// </summary>
    public sealed partial class CopilotSpaceResourcesAttributeMetadata
    {
        /// <summary>
        /// Repository ID for repository or file resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// File path for file resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// Text content for free text resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Name for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Issue or PR number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Chat attachment ID for uploaded files or media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_chat_attachment_id")]
        public int? CopilotChatAttachmentId { get; set; }

        /// <summary>
        /// Media type for media content resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// URL for media content resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Height for media content resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Width for media content resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResourcesAttributeMetadata" /> class.
        /// </summary>
        /// <param name="repositoryId">
        /// Repository ID for repository or file resources.
        /// </param>
        /// <param name="filePath">
        /// File path for file resources.
        /// </param>
        /// <param name="text">
        /// Text content for free text resources.
        /// </param>
        /// <param name="name">
        /// Name for the resource.
        /// </param>
        /// <param name="number">
        /// Issue or PR number.
        /// </param>
        /// <param name="copilotChatAttachmentId">
        /// Chat attachment ID for uploaded files or media.
        /// </param>
        /// <param name="mediaType">
        /// Media type for media content resources.
        /// </param>
        /// <param name="url">
        /// URL for media content resources.
        /// </param>
        /// <param name="height">
        /// Height for media content resources.
        /// </param>
        /// <param name="width">
        /// Width for media content resources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpaceResourcesAttributeMetadata(
            int? repositoryId,
            string? filePath,
            string? text,
            string? name,
            int? number,
            int? copilotChatAttachmentId,
            string? mediaType,
            string? url,
            int? height,
            int? width)
        {
            this.RepositoryId = repositoryId;
            this.FilePath = filePath;
            this.Text = text;
            this.Name = name;
            this.Number = number;
            this.CopilotChatAttachmentId = copilotChatAttachmentId;
            this.MediaType = mediaType;
            this.Url = url;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceResourcesAttributeMetadata" /> class.
        /// </summary>
        public CopilotSpaceResourcesAttributeMetadata()
        {
        }

    }
}