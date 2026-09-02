#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions cache storage limit for an organization<br/>
        /// Sets GitHub Actions cache storage limit for an organization. All organizations and repositories under this<br/>
        /// organization may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForOrganizationAsync(
            string org,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForOrganization request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for an organization<br/>
        /// Sets GitHub Actions cache storage limit for an organization. All organizations and repositories under this<br/>
        /// organization may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetActionsCacheStorageLimitForOrganizationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForOrganization request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for an organization<br/>
        /// Sets GitHub Actions cache storage limit for an organization. All organizations and repositories under this<br/>
        /// organization may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="maxCacheSizeGb">
        /// For repositories in the organization, the maximum size limit for the sum of all caches in a repository, in gigabytes.<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForOrganizationAsync(
            string org,
            long? maxCacheSizeGb = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}