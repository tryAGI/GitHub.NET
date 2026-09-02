#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get cluster deployment records job status<br/>
        /// Get the status and results of a previously created cluster deployment records job.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsGetClusterDeploymentRecordsJobResponse> OrgsGetClusterDeploymentRecordsJobAsync(
            string org,
            string cluster,
            int jobId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get cluster deployment records job status<br/>
        /// Get the status and results of a previously created cluster deployment records job.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cluster"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsGetClusterDeploymentRecordsJobResponse>> OrgsGetClusterDeploymentRecordsJobAsResponseAsync(
            string org,
            string cluster,
            int jobId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}