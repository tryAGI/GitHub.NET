
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The deployment payload that could not be processed.
    /// </summary>
    public sealed partial class OrgsSetClusterDeploymentRecordsResponseErrorDeployment
    {
        /// <summary>
        /// The name of the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The digest of the artifact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// The name of the deployment that failed processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// The version of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The deployment status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The repository associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_repository")]
        public string? GithubRepository { get; set; }

        /// <summary>
        /// Custom metadata tags for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Runtime risk classifications for the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_risks")]
        public global::System.Collections.Generic.IList<string>? RuntimeRisks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponseErrorDeployment" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the artifact.
        /// </param>
        /// <param name="digest">
        /// The digest of the artifact.
        /// </param>
        /// <param name="deploymentName">
        /// The name of the deployment that failed processing.
        /// </param>
        /// <param name="version">
        /// The version of the deployment.
        /// </param>
        /// <param name="status">
        /// The deployment status.
        /// </param>
        /// <param name="githubRepository">
        /// The repository associated with the deployment.
        /// </param>
        /// <param name="tags">
        /// Custom metadata tags for the deployment.
        /// </param>
        /// <param name="runtimeRisks">
        /// Runtime risk classifications for the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetClusterDeploymentRecordsResponseErrorDeployment(
            string? name,
            string? digest,
            string? deploymentName,
            string? version,
            string? status,
            string? githubRepository,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<string>? runtimeRisks)
        {
            this.Name = name;
            this.Digest = digest;
            this.DeploymentName = deploymentName;
            this.Version = version;
            this.Status = status;
            this.GithubRepository = githubRepository;
            this.Tags = tags;
            this.RuntimeRisks = runtimeRisks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponseErrorDeployment" /> class.
        /// </summary>
        public OrgsSetClusterDeploymentRecordsResponseErrorDeployment()
        {
        }

    }
}