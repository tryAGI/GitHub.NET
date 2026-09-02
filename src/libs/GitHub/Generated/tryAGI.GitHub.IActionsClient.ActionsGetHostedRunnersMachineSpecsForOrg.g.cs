#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub-hosted runners machine specs for an organization<br/>
        /// Get the list of machine specs available for GitHub-hosted runners for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsGetHostedRunnersMachineSpecsForOrgResponse> ActionsGetHostedRunnersMachineSpecsForOrgAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get GitHub-hosted runners machine specs for an organization<br/>
        /// Get the list of machine specs available for GitHub-hosted runners for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsGetHostedRunnersMachineSpecsForOrgResponse>> ActionsGetHostedRunnersMachineSpecsForOrgAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}