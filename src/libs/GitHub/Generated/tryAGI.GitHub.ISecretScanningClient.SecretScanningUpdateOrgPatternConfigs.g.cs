#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Update organization pattern configurations<br/>
        /// Updates the secret scanning pattern configurations for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsResponse> SecretScanningUpdateOrgPatternConfigsAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization pattern configurations<br/>
        /// Updates the secret scanning pattern configurations for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsResponse>> SecretScanningUpdateOrgPatternConfigsAsResponseAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization pattern configurations<br/>
        /// Updates the secret scanning pattern configurations for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patternConfigVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="providerPatternSettings">
        /// Pattern settings for provider patterns.
        /// </param>
        /// <param name="customPatternSettings">
        /// Pattern settings for custom patterns.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsResponse> SecretScanningUpdateOrgPatternConfigsAsync(
            string org,
            string? patternConfigVersion = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSetting>? providerPatternSettings = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSetting>? customPatternSettings = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}