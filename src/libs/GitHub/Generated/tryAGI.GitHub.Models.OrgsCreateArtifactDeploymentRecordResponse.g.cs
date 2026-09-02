
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsCreateArtifactDeploymentRecordResponse
    {
        /// <summary>
        /// The number of deployment records created
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactDeploymentRecordResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The number of deployment records created
        /// </param>
        /// <param name="deploymentRecords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateArtifactDeploymentRecordResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ArtifactDeploymentRecord>? deploymentRecords)
        {
            this.TotalCount = totalCount;
            this.DeploymentRecords = deploymentRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactDeploymentRecordResponse" /> class.
        /// </summary>
        public OrgsCreateArtifactDeploymentRecordResponse()
        {
        }

    }
}