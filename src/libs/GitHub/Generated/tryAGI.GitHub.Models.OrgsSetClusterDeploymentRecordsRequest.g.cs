
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSetClusterDeploymentRecordsRequest
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
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsRequestDeployment> Deployments { get; set; }

        /// <summary>
        /// When enabled, deployments associated with repositories the actor can write to are processed<br/>
        /// while deployments associated with repositories that cannot be resolved or written to by the actor<br/>
        /// are skipped and reported in the `errors` array. When false (the default), the endpoint returns<br/>
        /// an error if any targeted repository cannot be resolved, the actor lacks write access, or no matching attestation can be found.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_success")]
        public bool? PartialSuccess { get; set; }

        /// <summary>
        /// If true, the endpoint will return the set records in the response body<br/>
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
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsRequest" /> class.
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
        /// <param name="partialSuccess">
        /// When enabled, deployments associated with repositories the actor can write to are processed<br/>
        /// while deployments associated with repositories that cannot be resolved or written to by the actor<br/>
        /// are skipped and reported in the `errors` array. When false (the default), the endpoint returns<br/>
        /// an error if any targeted repository cannot be resolved, the actor lacks write access, or no matching attestation can be found.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnRecords">
        /// If true, the endpoint will return the set records in the response body<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetClusterDeploymentRecordsRequest(
            string logicalEnvironment,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsRequestDeployment> deployments,
            string? physicalEnvironment,
            bool? partialSuccess,
            bool? returnRecords)
        {
            this.LogicalEnvironment = logicalEnvironment ?? throw new global::System.ArgumentNullException(nameof(logicalEnvironment));
            this.PhysicalEnvironment = physicalEnvironment;
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
            this.PartialSuccess = partialSuccess;
            this.ReturnRecords = returnRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsRequest" /> class.
        /// </summary>
        public OrgsSetClusterDeploymentRecordsRequest()
        {
        }

    }
}