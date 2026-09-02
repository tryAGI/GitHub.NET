#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Update a hosted compute network configuration for an organization<br/>
        /// Updates a hosted compute network configuration for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.NetworkConfiguration> HostedComputeUpdateNetworkConfigurationForOrgAsync(
            string org,
            string networkConfigurationId,

            global::tryAGI.GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a hosted compute network configuration for an organization<br/>
        /// Updates a hosted compute network configuration for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.NetworkConfiguration>> HostedComputeUpdateNetworkConfigurationForOrgAsResponseAsync(
            string org,
            string networkConfigurationId,

            global::tryAGI.GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a hosted compute network configuration for an organization<br/>
        /// Updates a hosted compute network configuration for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="name">
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service to use for the network configuration.
        /// </param>
        /// <param name="networkSettingsIds">
        /// A list of identifiers of the network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </param>
        /// <param name="failoverNetworkSettingsIds">
        /// A list of identifiers of the failover network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </param>
        /// <param name="failoverNetworkEnabled">
        /// Indicates whether the failover network resource is enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.NetworkConfiguration> HostedComputeUpdateNetworkConfigurationForOrgAsync(
            string org,
            string networkConfigurationId,
            string? name = default,
            global::tryAGI.GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? computeService = default,
            global::System.Collections.Generic.IList<string>? networkSettingsIds = default,
            global::System.Collections.Generic.IList<string>? failoverNetworkSettingsIds = default,
            bool? failoverNetworkEnabled = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}