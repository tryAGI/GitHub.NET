#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions cache storage limit for an enterprise<br/>
        /// Sets GitHub Actions cache storage limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForEnterprise request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for an enterprise<br/>
        /// Sets GitHub Actions cache storage limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetActionsCacheStorageLimitForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForEnterprise request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for an enterprise<br/>
        /// Sets GitHub Actions cache storage limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="maxCacheSizeGb">
        /// For repositories &amp; organizations in an enterprise, the maximum size limit for the sum of all caches in a repository, in gigabytes.<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForEnterpriseAsync(
            string enterprise,
            long? maxCacheSizeGb = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}