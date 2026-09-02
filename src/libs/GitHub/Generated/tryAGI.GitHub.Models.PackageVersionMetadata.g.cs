
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PackageVersionMetadata
    {
        /// <summary>
        /// Example: docker
        /// </summary>
        /// <example>docker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PackageVersionMetadataPackageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PackageVersionMetadataPackageType PackageType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        public global::tryAGI.GitHub.PackageVersionMetadataContainer? Container { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker")]
        public global::tryAGI.GitHub.PackageVersionMetadataDocker? Docker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadata" /> class.
        /// </summary>
        /// <param name="packageType">
        /// Example: docker
        /// </param>
        /// <param name="container"></param>
        /// <param name="docker"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PackageVersionMetadata(
            global::tryAGI.GitHub.PackageVersionMetadataPackageType packageType,
            global::tryAGI.GitHub.PackageVersionMetadataContainer? container,
            global::tryAGI.GitHub.PackageVersionMetadataDocker? docker)
        {
            this.PackageType = packageType;
            this.Container = container;
            this.Docker = docker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadata" /> class.
        /// </summary>
        public PackageVersionMetadata()
        {
        }

    }
}