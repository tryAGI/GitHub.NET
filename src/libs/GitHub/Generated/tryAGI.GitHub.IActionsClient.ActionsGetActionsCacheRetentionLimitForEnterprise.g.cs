#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions cache retention limit for an enterprise<br/>
        /// Gets GitHub Actions cache retention limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsCacheRetentionLimitForEnterprise> ActionsGetActionsCacheRetentionLimitForEnterpriseAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get GitHub Actions cache retention limit for an enterprise<br/>
        /// Gets GitHub Actions cache retention limit for an enterprise. All organizations and repositories under this<br/>
        /// enterprise may not set a higher cache retention limit.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsCacheRetentionLimitForEnterprise>> ActionsGetActionsCacheRetentionLimitForEnterpriseAsResponseAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}