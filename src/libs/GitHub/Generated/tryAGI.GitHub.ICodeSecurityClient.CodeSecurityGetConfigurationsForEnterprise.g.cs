#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Get code security configurations for an enterprise<br/>
        /// Lists all code security configurations available in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeSecurityConfiguration>> CodeSecurityGetConfigurationsForEnterpriseAsync(
            string enterprise,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get code security configurations for an enterprise<br/>
        /// Lists all code security configurations available in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeSecurityConfiguration>>> CodeSecurityGetConfigurationsForEnterpriseAsResponseAsync(
            string enterprise,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}