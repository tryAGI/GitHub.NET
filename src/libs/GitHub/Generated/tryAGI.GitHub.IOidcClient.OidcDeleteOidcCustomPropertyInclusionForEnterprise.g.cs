#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// Delete an OIDC custom property inclusion for an enterprise<br/>
        /// Removes a repository custom property from being included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OidcDeleteOidcCustomPropertyInclusionForEnterpriseAsync(
            string enterprise,
            string customPropertyName,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an OIDC custom property inclusion for an enterprise<br/>
        /// Removes a repository custom property from being included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> OidcDeleteOidcCustomPropertyInclusionForEnterpriseAsResponseAsync(
            string enterprise,
            string customPropertyName,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}