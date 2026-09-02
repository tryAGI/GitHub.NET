
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateClusterDeploymentRecordsJobRequestDeployment
    {
        /// <summary>
        /// The name of the artifact.
        /// </summary>
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
        /// The deployment status of the artifact.<br/>
        /// Default Value: deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatusJsonConverter))]
        public global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus? Status { get; set; }

        /// <summary>
        /// The unique identifier for the deployment represented by the new record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// The name of the GitHub repository associated with the artifact.<br/>
        /// Example: my-github-repo
        /// </summary>
        /// <example>my-github-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_repository")]
        public string? GithubRepository { get; set; }

        /// <summary>
        /// Key-value pairs to tag the deployment record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// A list of runtime risks associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_risks")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk>? RuntimeRisks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobRequestDeployment" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the artifact.
        /// </param>
        /// <param name="digest">
        /// The hex encoded digest of the artifact.
        /// </param>
        /// <param name="deploymentName">
        /// The unique identifier for the deployment represented by the new record.
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="status">
        /// The deployment status of the artifact.<br/>
        /// Default Value: deployed
        /// </param>
        /// <param name="githubRepository">
        /// The name of the GitHub repository associated with the artifact.<br/>
        /// Example: my-github-repo
        /// </param>
        /// <param name="tags">
        /// Key-value pairs to tag the deployment record.
        /// </param>
        /// <param name="runtimeRisks">
        /// A list of runtime risks associated with the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateClusterDeploymentRecordsJobRequestDeployment(
            string name,
            string digest,
            string deploymentName,
            string? version,
            global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeploymentStatus? status,
            string? githubRepository,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeploymentRuntimeRisk>? runtimeRisks)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Version = version;
            this.Status = status;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.GithubRepository = githubRepository;
            this.Tags = tags;
            this.RuntimeRisks = runtimeRisks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobRequestDeployment" /> class.
        /// </summary>
        public OrgsCreateClusterDeploymentRecordsJobRequestDeployment()
        {
        }

    }
}