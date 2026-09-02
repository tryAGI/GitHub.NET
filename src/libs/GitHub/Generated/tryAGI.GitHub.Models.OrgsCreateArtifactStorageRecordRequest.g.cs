
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateArtifactStorageRecordRequest
    {
        /// <summary>
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </summary>
        /// <example>libfoo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </summary>
        /// <example>sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </summary>
        /// <example>1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </summary>
        /// <example>https://reg.example.com/artifactory/bar/libfoo-1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </summary>
        /// <example>com/github/bar/libfoo-1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </summary>
        /// <example>https://reg.example.com/artifactory/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegistryUrl { get; set; }

        /// <summary>
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </summary>
        /// <example>bar</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsCreateArtifactStorageRecordRequestStatusJsonConverter))]
        public global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordRequestStatus? Status { get; set; }

        /// <summary>
        /// The name of the GitHub repository associated with the artifact. This should be used<br/>
        /// when there are no provenance attestations available for the artifact. The repository<br/>
        /// must belong to the organization specified in the path parameter.<br/>
        /// If a provenance attestation is available for the artifact, the API will use<br/>
        /// the repository information from the attestation instead of this parameter.<br/>
        /// Example: my-github-repo
        /// </summary>
        /// <example>my-github-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_repository")]
        public string? GithubRepository { get; set; }

        /// <summary>
        /// If true, the endpoint will return the created record in the response body.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_records")]
        public bool? ReturnRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </param>
        /// <param name="digest">
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </param>
        /// <param name="registryUrl">
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="artifactUrl">
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </param>
        /// <param name="path">
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </param>
        /// <param name="repository">
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </param>
        /// <param name="status">
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </param>
        /// <param name="githubRepository">
        /// The name of the GitHub repository associated with the artifact. This should be used<br/>
        /// when there are no provenance attestations available for the artifact. The repository<br/>
        /// must belong to the organization specified in the path parameter.<br/>
        /// If a provenance attestation is available for the artifact, the API will use<br/>
        /// the repository information from the attestation instead of this parameter.<br/>
        /// Example: my-github-repo
        /// </param>
        /// <param name="returnRecords">
        /// If true, the endpoint will return the created record in the response body.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateArtifactStorageRecordRequest(
            string name,
            string digest,
            string registryUrl,
            string? version,
            string? artifactUrl,
            string? path,
            string? repository,
            global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordRequestStatus? status,
            string? githubRepository,
            bool? returnRecords)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Version = version;
            this.ArtifactUrl = artifactUrl;
            this.Path = path;
            this.RegistryUrl = registryUrl ?? throw new global::System.ArgumentNullException(nameof(registryUrl));
            this.Repository = repository;
            this.Status = status;
            this.GithubRepository = githubRepository;
            this.ReturnRecords = returnRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordRequest" /> class.
        /// </summary>
        public OrgsCreateArtifactStorageRecordRequest()
        {
        }

    }
}