
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSetClusterDeploymentRecordsResponse2
    {
        /// <summary>
        /// The number of deployment records created or updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_records")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ArtifactDeploymentRecord>? DeploymentRecords { get; set; }

        /// <summary>
        /// A list of errors for deployments that could not be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponse2" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of deployment records created or updated.
        /// </param>
        /// <param name="deploymentRecords"></param>
        /// <param name="errors">
        /// A list of errors for deployments that could not be processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetClusterDeploymentRecordsResponse2(
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ArtifactDeploymentRecord>? deploymentRecords,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseError>? errors)
        {
            this.TotalCount = totalCount;
            this.DeploymentRecords = deploymentRecords;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponse2" /> class.
        /// </summary>
        public OrgsSetClusterDeploymentRecordsResponse2()
        {
        }

    }
}