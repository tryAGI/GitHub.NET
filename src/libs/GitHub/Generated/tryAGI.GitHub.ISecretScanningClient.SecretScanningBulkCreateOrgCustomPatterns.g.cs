#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Bulk create organization custom patterns<br/>
        /// Bulk creates secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsResponse> SecretScanningBulkCreateOrgCustomPatternsAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create organization custom patterns<br/>
        /// Bulk creates secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsResponse>> SecretScanningBulkCreateOrgCustomPatternsAsResponseAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create organization custom patterns<br/>
        /// Bulk creates secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patterns">
        /// The list of custom patterns to create.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsResponse> SecretScanningBulkCreateOrgCustomPatternsAsync(
            string org,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToCreate> patterns,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}