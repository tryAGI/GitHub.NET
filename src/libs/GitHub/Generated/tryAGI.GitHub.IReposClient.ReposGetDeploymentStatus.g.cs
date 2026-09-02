#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a deployment status<br/>
        /// Users with pull access can view a deployment status for a deployment:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statusId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.DeploymentStatus> ReposGetDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            int statusId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a deployment status<br/>
        /// Users with pull access can view a deployment status for a deployment:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statusId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.DeploymentStatus>> ReposGetDeploymentStatusAsResponseAsync(
            string owner,
            string repo,
            int deploymentId,
            int statusId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}