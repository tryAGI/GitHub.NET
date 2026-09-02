#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// Create an OIDC custom property inclusion for an enterprise<br/>
        /// Adds a repository custom property to be included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OidcCustomPropertyInclusion> OidcCreateOidcCustomPropertyInclusionForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.OidcCustomPropertyInclusionInput request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OIDC custom property inclusion for an enterprise<br/>
        /// Adds a repository custom property to be included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OidcCustomPropertyInclusion>> OidcCreateOidcCustomPropertyInclusionForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.OidcCustomPropertyInclusionInput request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an OIDC custom property inclusion for an enterprise<br/>
        /// Adds a repository custom property to be included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="customPropertyName">
        /// The name of the custom property to include in the OIDC token
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OidcCustomPropertyInclusion> OidcCreateOidcCustomPropertyInclusionForEnterpriseAsync(
            string enterprise,
            string customPropertyName,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}