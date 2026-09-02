#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse> OrgsCreateArtifactDeploymentRecordAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse>> OrgsCreateArtifactDeploymentRecordAsResponseAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an artifact deployment record<br/>
        /// Create or update deployment records for an artifact associated<br/>
        /// with an organization.<br/>
        /// This endpoint allows you to record information about a specific<br/>
        /// artifact, such as its name, digest, environments, cluster, and<br/>
        /// deployment.<br/>
        /// The deployment name has to be uniqe within a cluster (i.e a<br/>
        /// combination of logical, physical environment and cluster) as it<br/>
        /// identifies unique deployment.<br/>
        /// Multiple requests for the same combination of logical, physical<br/>
        /// environment, cluster and deployment name will only create one<br/>
        /// record, successive request will update the existing record.<br/>
        /// This allows for a stable tracking of a deployment where the actual<br/>
        /// deployed artifact can change over time.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </param>
        /// <param name="digest">
        /// The hex encoded digest of the artifact.
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="status">
        /// The status of the artifact. Can be either deployed or decommissioned.
        /// </param>
        /// <param name="logicalEnvironment">
        /// The stage of the deployment.
        /// </param>
        /// <param name="physicalEnvironment">
        /// The physical region of the deployment.
        /// </param>
        /// <param name="cluster">
        /// The deployment cluster.
        /// </param>
        /// <param name="deploymentName">
        /// The unique identifier for the deployment represented by the new record. To accommodate differing<br/>
        /// containers and namespaces within a cluster, the following format is recommended:<br/>
        /// {namespaceName}-{deploymentName}-{containerName}.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordResponse> OrgsCreateArtifactDeploymentRecordAsync(
            string org,
            string name,
            string digest,
            global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestStatus status,
            string logicalEnvironment,
            string deploymentName,
            string? version = default,
            string? physicalEnvironment = default,
            string? cluster = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateArtifactDeploymentRecordRequestRuntimeRisk>? runtimeRisks = default,
            string? githubRepository = default,
            bool? returnRecords = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}