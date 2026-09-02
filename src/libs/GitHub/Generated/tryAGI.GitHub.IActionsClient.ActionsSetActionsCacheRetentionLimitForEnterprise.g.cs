#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions cache retention limit for an enterprise<br/>
        /// Sets GitHub Actions cache retention limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheRetentionLimitForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.ActionsCacheRetentionLimitForEnterprise request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache retention limit for an enterprise<br/>
        /// Sets GitHub Actions cache retention limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetActionsCacheRetentionLimitForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.ActionsCacheRetentionLimitForEnterprise request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache retention limit for an enterprise<br/>
        /// Sets GitHub Actions cache retention limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="maxCacheRetentionDays">
        /// For repositories &amp; organizations in an enterprise, the maximum duration, in days, for which caches in a repository may be retained.<br/>
        /// Example: 14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheRetentionLimitForEnterpriseAsync(
            string enterprise,
            int? maxCacheRetentionDays = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}