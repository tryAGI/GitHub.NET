#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a GitHub-hosted runner for an organization<br/>
        /// Gets a GitHub-hosted runner configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsHostedRunner> ActionsGetHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a GitHub-hosted runner for an organization<br/>
        /// Gets a GitHub-hosted runner configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsHostedRunner>> ActionsGetHostedRunnerForOrgAsResponseAsync(
            string org,
            int hostedRunnerId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}