#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create a cluster deployment records job<br/>
        /// Create a background job to set deployment records for a given cluster.<br/>
        /// Performs validation and permission checks synchronously, returning rejected<br/>
        /// deployments immediately, then enqueues a background job for the actual<br/>
        /// deployment updates. Use the companion GET endpoint to poll for job status.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobResponse> OrgsCreateClusterDeploymentRecordsJobAsync(
            string org,
            string cluster,

            global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cluster deployment records job<br/>
        /// Create a background job to set deployment records for a given cluster.<br/>
        /// Performs validation and permission checks synchronously, returning rejected<br/>
        /// deployments immediately, then enqueues a background job for the actual<br/>
        /// deployment updates. Use the companion GET endpoint to poll for job status.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobResponse>> OrgsCreateClusterDeploymentRecordsJobAsResponseAsync(
            string org,
            string cluster,

            global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a cluster deployment records job<br/>
        /// Create a background job to set deployment records for a given cluster.<br/>
        /// Performs validation and permission checks synchronously, returning rejected<br/>
        /// deployments immediately, then enqueues a background job for the actual<br/>
        /// deployment updates. Use the companion GET endpoint to poll for job status.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobResponse> OrgsCreateClusterDeploymentRecordsJobAsync(
            string org,
            string cluster,
            string logicalEnvironment,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrgsCreateClusterDeploymentRecordsJobRequestDeployment> deployments,
            string? physicalEnvironment = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}