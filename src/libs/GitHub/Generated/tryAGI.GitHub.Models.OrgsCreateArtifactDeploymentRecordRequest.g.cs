
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateArtifactDeploymentRecordRequest
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
        /// The hex encoded digest of the artifact.
        /// </summary>
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
        /// The status of the artifact. Can be either deployed or decommissioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsCreateArtifactDeploymentRecordRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestStatus Status { get; set; }

        /// <summary>
        /// The stage of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LogicalEnvironment { get; set; }

        /// <summary>
        /// The physical region of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("physical_environment")]
        public string? PhysicalEnvironment { get; set; }

        /// <summary>
        /// The deployment cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public string? Cluster { get; set; }

        /// <summary>
        /// The unique identifier for the deployment represented by the new record. To accommodate differing<br/>
        /// containers and namespaces within a cluster, the following format is recommended:<br/>
        /// {namespaceName}-{deploymentName}-{containerName}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// The tags associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// A list of runtime risks associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_risks")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk>? RuntimeRisks { get; set; }

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
        /// If true, the endpoint will return the created or updated record in the response body.<br/>
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
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactDeploymentRecordRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </param>
        /// <param name="digest">
        /// The hex encoded digest of the artifact.
        /// </param>
        /// <param name="status">
        /// The status of the artifact. Can be either deployed or decommissioned.
        /// </param>
        /// <param name="logicalEnvironment">
        /// The stage of the deployment.
        /// </param>
        /// <param name="deploymentName">
        /// The unique identifier for the deployment represented by the new record. To accommodate differing<br/>
        /// containers and namespaces within a cluster, the following format is recommended:<br/>
        /// {namespaceName}-{deploymentName}-{containerName}.
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="physicalEnvironment">
        /// The physical region of the deployment.
        /// </param>
        /// <param name="cluster">
        /// The deployment cluster.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the deployment.
        /// </param>
        /// <param name="runtimeRisks">
        /// A list of runtime risks associated with the deployment.
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
        /// If true, the endpoint will return the created or updated record in the response body.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateArtifactDeploymentRecordRequest(
            string name,
            string digest,
            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestStatus status,
            string logicalEnvironment,
            string deploymentName,
            string? version,
            string? physicalEnvironment,
            string? cluster,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk>? runtimeRisks,
            string? githubRepository,
            bool? returnRecords)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Version = version;
            this.Status = status;
            this.LogicalEnvironment = logicalEnvironment ?? throw new global::System.ArgumentNullException(nameof(logicalEnvironment));
            this.PhysicalEnvironment = physicalEnvironment;
            this.Cluster = cluster;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Tags = tags;
            this.RuntimeRisks = runtimeRisks;
            this.GithubRepository = githubRepository;
            this.ReturnRecords = returnRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactDeploymentRecordRequest" /> class.
        /// </summary>
        public OrgsCreateArtifactDeploymentRecordRequest()
        {
        }

    }
}