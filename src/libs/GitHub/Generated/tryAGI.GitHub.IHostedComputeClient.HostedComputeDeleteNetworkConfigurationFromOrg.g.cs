#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Delete a hosted compute network configuration from an organization<br/>
        /// Deletes a hosted compute network configuration from an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task HostedComputeDeleteNetworkConfigurationFromOrgAsync(
            string org,
            string networkConfigurationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a hosted compute network configuration from an organization<br/>
        /// Deletes a hosted compute network configuration from an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> HostedComputeDeleteNetworkConfigurationFromOrgAsResponseAsync(
            string org,
            string networkConfigurationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}