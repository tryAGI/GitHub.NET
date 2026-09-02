#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions cache storage limit for an organization<br/>
        /// Gets GitHub Actions cache storage limit for an organization. All repositories under this<br/>
        /// organization may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsCacheStorageLimitForOrganization> ActionsGetActionsCacheStorageLimitForOrganizationAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get GitHub Actions cache storage limit for an organization<br/>
        /// Gets GitHub Actions cache storage limit for an organization. All repositories under this<br/>
        /// organization may not set a higher cache storage limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsCacheStorageLimitForOrganization>> ActionsGetActionsCacheStorageLimitForOrganizationAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}