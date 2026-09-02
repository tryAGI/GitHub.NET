#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// List OIDC custom property inclusions for an enterprise<br/>
        /// Lists the repository custom properties that are included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OidcCustomPropertyInclusion>> OidcListOidcCustomPropertyInclusionsForEnterpriseAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List OIDC custom property inclusions for an enterprise<br/>
        /// Lists the repository custom properties that are included in the OIDC token for repository actions in an enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OidcCustomPropertyInclusion>>> OidcListOidcCustomPropertyInclusionsForEnterpriseAsResponseAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}