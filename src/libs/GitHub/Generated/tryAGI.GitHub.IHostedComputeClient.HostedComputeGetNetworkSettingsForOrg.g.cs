#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Get a hosted compute network settings resource for an organization<br/>
        /// Gets a hosted compute network settings resource configured for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkSettingsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.NetworkSettings> HostedComputeGetNetworkSettingsForOrgAsync(
            string org,
            string networkSettingsId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a hosted compute network settings resource for an organization<br/>
        /// Gets a hosted compute network settings resource configured for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkSettingsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.NetworkSettings>> HostedComputeGetNetworkSettingsForOrgAsResponseAsync(
            string org,
            string networkSettingsId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}