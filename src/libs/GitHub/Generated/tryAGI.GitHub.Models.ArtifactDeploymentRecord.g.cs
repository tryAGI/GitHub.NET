
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Artifact Metadata Deployment Record
    /// </summary>
    public sealed partial class ArtifactDeploymentRecord
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public string? Digest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_environment")]
        public string? LogicalEnvironment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("physical_environment")]
        public string? PhysicalEnvironment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public string? Cluster { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// A list of runtime risks associated with the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_risks")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ArtifactDeploymentRecordRuntimeRisk>? RuntimeRisks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the provenance attestation associated with the deployment record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestation_id")]
        public int? AttestationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactDeploymentRecord" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="digest"></param>
        /// <param name="logicalEnvironment"></param>
        /// <param name="physicalEnvironment"></param>
        /// <param name="cluster"></param>
        /// <param name="deploymentName"></param>
        /// <param name="tags"></param>
        /// <param name="runtimeRisks">
        /// A list of runtime risks associated with the deployment.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="attestationId">
        /// The ID of the provenance attestation associated with the deployment record.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactDeploymentRecord(
            int? id,
            string? digest,
            string? logicalEnvironment,
            string? physicalEnvironment,
            string? cluster,
            string? deploymentName,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ArtifactDeploymentRecordRuntimeRisk>? runtimeRisks,
            string? createdAt,
            string? updatedAt,
            int? attestationId)
        {
            this.Id = id;
            this.Digest = digest;
            this.LogicalEnvironment = logicalEnvironment;
            this.PhysicalEnvironment = physicalEnvironment;
            this.Cluster = cluster;
            this.DeploymentName = deploymentName;
            this.Tags = tags;
            this.RuntimeRisks = runtimeRisks;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AttestationId = attestationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactDeploymentRecord" /> class.
        /// </summary>
        public ArtifactDeploymentRecord()
        {
        }

    }
}