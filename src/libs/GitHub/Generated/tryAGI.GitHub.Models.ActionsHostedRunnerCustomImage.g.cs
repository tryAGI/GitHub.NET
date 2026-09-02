
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provides details of a custom runner image
    /// </summary>
    public sealed partial class ActionsHostedRunnerCustomImage
    {
        /// <summary>
        /// The ID of the image. Use this ID for the `image` parameter when creating a new larger runner.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </summary>
        /// <example>linux-x64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Platform { get; set; }

        /// <summary>
        /// Total size of all the image versions in GB.<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_versions_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalVersionsSize { get; set; }

        /// <summary>
        /// Display name for this image.<br/>
        /// Example: CustomImage
        /// </summary>
        /// <example>CustomImage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The image provider.<br/>
        /// Example: custom
        /// </summary>
        /// <example>custom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The number of image versions associated with the image.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsCount { get; set; }

        /// <summary>
        /// The latest image version associated with the image.<br/>
        /// Example: 1.3.0
        /// </summary>
        /// <example>1.3.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersion { get; set; }

        /// <summary>
        /// The number of image versions associated with the image.<br/>
        /// Example: Ready
        /// </summary>
        /// <example>Ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCustomImage" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the image. Use this ID for the `image` parameter when creating a new larger runner.<br/>
        /// Example: 1
        /// </param>
        /// <param name="platform">
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </param>
        /// <param name="totalVersionsSize">
        /// Total size of all the image versions in GB.<br/>
        /// Example: 200
        /// </param>
        /// <param name="name">
        /// Display name for this image.<br/>
        /// Example: CustomImage
        /// </param>
        /// <param name="source">
        /// The image provider.<br/>
        /// Example: custom
        /// </param>
        /// <param name="versionsCount">
        /// The number of image versions associated with the image.<br/>
        /// Example: 4
        /// </param>
        /// <param name="latestVersion">
        /// The latest image version associated with the image.<br/>
        /// Example: 1.3.0
        /// </param>
        /// <param name="state">
        /// The number of image versions associated with the image.<br/>
        /// Example: Ready
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsHostedRunnerCustomImage(
            int id,
            string platform,
            int totalVersionsSize,
            string name,
            string source,
            int versionsCount,
            string latestVersion,
            string state)
        {
            this.Id = id;
            this.Platform = platform ?? throw new global::System.ArgumentNullException(nameof(platform));
            this.TotalVersionsSize = totalVersionsSize;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.VersionsCount = versionsCount;
            this.LatestVersion = latestVersion ?? throw new global::System.ArgumentNullException(nameof(latestVersion));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCustomImage" /> class.
        /// </summary>
        public ActionsHostedRunnerCustomImage()
        {
        }

    }
}