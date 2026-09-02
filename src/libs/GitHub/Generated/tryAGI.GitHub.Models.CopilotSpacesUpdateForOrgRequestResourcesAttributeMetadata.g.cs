
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Metadata specific to the resource type.
    /// </summary>
    public sealed partial class CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata(
            int? repositoryId,
            string? filePath,
            string? text,
            string? name,
            int? number)
        {
            this.RepositoryId = repositoryId;
            this.FilePath = filePath;
            this.Text = text;
            this.Name = name;
            this.Number = number;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata" /> class.
        /// </summary>
        public CopilotSpacesUpdateForOrgRequestResourcesAttributeMetadata()
        {
        }

    }
}