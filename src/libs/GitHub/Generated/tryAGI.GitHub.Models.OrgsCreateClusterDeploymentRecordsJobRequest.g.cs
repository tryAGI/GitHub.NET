
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateClusterDeploymentRecordsJobRequest
    {
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
        /// The list of deployments to record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeployment> Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobRequest" /> class.
        /// </summary>
        /// <param name="logicalEnvironment">
        /// The stage of the deployment.
        /// </param>
        /// <param name="deployments">
        /// The list of deployments to record.
        /// </param>
        /// <param name="physicalEnvironment">
        /// The physical region of the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateClusterDeploymentRecordsJobRequest(
            string logicalEnvironment,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeployment> deployments,
            string? physicalEnvironment)
        {
            this.LogicalEnvironment = logicalEnvironment ?? throw new global::System.ArgumentNullException(nameof(logicalEnvironment));
            this.PhysicalEnvironment = physicalEnvironment;
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateClusterDeploymentRecordsJobRequest" /> class.
        /// </summary>
        public OrgsCreateClusterDeploymentRecordsJobRequest()
        {
        }

    }
}