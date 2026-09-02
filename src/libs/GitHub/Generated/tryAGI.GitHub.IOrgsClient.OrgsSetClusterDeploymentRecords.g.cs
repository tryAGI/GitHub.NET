#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Set cluster deployment records<br/>
        /// Set deployment records for a given cluster.<br/>
        /// If proposed records in the 'deployments' field have identical 'cluster', 'logical_environment',<br/>
        /// 'physical_environment', and 'deployment_name' values as existing records, the existing records will be updated.<br/>
        /// If no existing records match, new records will be created.<br/>
        /// Note: Artifacts are uniquely identified by the combination of their repository and digest fields. If two entries in the deployments<br/>
        /// array resolve to the same repository and have identical digest fields but differing name and version fields, the endpoint will use<br/>
        /// the artifact name and version from the record processed first, since a single artifact (identified by repository and digest) can<br/>
        /// only have one name and version.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponse> OrgsSetClusterDeploymentRecordsAsync(
            string org,
            string cluster,

            global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set cluster deployment records<br/>
        /// Set deployment records for a given cluster.<br/>
        /// If proposed records in the 'deployments' field have identical 'cluster', 'logical_environment',<br/>
        /// 'physical_environment', and 'deployment_name' values as existing records, the existing records will be updated.<br/>
        /// If no existing records match, new records will be created.<br/>
        /// Note: Artifacts are uniquely identified by the combination of their repository and digest fields. If two entries in the deployments<br/>
        /// array resolve to the same repository and have identical digest fields but differing name and version fields, the endpoint will use<br/>
        /// the artifact name and version from the record processed first, since a single artifact (identified by repository and digest) can<br/>
        /// only have one name and version.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponse>> OrgsSetClusterDeploymentRecordsAsResponseAsync(
            string org,
            string cluster,

            global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set cluster deployment records<br/>
        /// Set deployment records for a given cluster.<br/>
        /// If proposed records in the 'deployments' field have identical 'cluster', 'logical_environment',<br/>
        /// 'physical_environment', and 'deployment_name' values as existing records, the existing records will be updated.<br/>
        /// If no existing records match, new records will be created.<br/>
        /// Note: Artifacts are uniquely identified by the combination of their repository and digest fields. If two entries in the deployments<br/>
        /// array resolve to the same repository and have identical digest fields but differing name and version fields, the endpoint will use<br/>
        /// the artifact name and version from the record processed first, since a single artifact (identified by repository and digest) can<br/>
        /// only have one name and version.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="logicalEnvironment">
        /// The stage of the deployment.
        /// </param>
        /// <param name="physicalEnvironment">
        /// The physical region of the deployment.
        /// </param>
        /// <param name="deployments">
        /// The list of deployments to record.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponse> OrgsSetClusterDeploymentRecordsAsync(
            string org,
            string cluster,
            string logicalEnvironment,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsRequestDeployment> deployments,
            string? physicalEnvironment = default,
            bool? partialSuccess = default,
            bool? returnRecords = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}