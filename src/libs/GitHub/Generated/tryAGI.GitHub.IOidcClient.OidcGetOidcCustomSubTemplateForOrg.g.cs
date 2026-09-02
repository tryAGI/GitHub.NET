#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// Get the customization template for an OIDC subject claim for an organization<br/>
        /// Gets the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OidcCustomSub> OidcGetOidcCustomSubTemplateForOrgAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the customization template for an OIDC subject claim for an organization<br/>
        /// Gets the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OidcCustomSub>> OidcGetOidcCustomSubTemplateForOrgAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}