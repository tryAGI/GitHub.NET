#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions cache retention limit for an organization<br/>
        /// Sets GitHub Actions cache retention limit for an organization. All repositories under this<br/>
        /// organization may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheRetentionLimitForOrganizationAsync(
            string org,

            global::tryAGI.GitHub.ActionsCacheRetentionLimitForOrganization request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache retention limit for an organization<br/>
        /// Sets GitHub Actions cache retention limit for an organization. All repositories under this<br/>
        /// organization may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetActionsCacheRetentionLimitForOrganizationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.ActionsCacheRetentionLimitForOrganization request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache retention limit for an organization<br/>
        /// Sets GitHub Actions cache retention limit for an organization. All repositories under this<br/>
        /// organization may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:organization` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="maxCacheRetentionDays">
        /// For repositories in this organization, the maximum duration, in days, for which caches in a repository may be retained.<br/>
        /// Example: 14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheRetentionLimitForOrganizationAsync(
            string org,
            int? maxCacheRetentionDays = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}