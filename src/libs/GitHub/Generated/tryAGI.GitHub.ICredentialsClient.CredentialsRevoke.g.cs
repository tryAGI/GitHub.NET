#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICredentialsClient
    {
        /// <summary>
        /// Revoke a list of credentials<br/>
        /// Submit a list of credentials to be revoked. This endpoint is intended to revoke credentials the caller does not own and may have found exposed on GitHub.com or elsewhere. It can also be used for credentials associated with an old user account that you no longer have access to. Credential owners will be notified of the revocation.<br/>
        /// This endpoint currently accepts the following credential types:<br/>
        /// - Personal access tokens (classic) (`ghp_`)<br/>
        /// - Fine-grained personal access tokens (`github_pat_`)<br/>
        /// - OAuth app access tokens (`gho_`)<br/>
        /// - User-to-server tokens from GitHub Apps (`ghu_`)<br/>
        /// - Refresh tokens from GitHub Apps (`ghr_`)<br/>
        /// Revoked credentials may impact users on GitHub Free, Pro, &amp; Team and GitHub Enterprise Cloud, and GitHub Enterprise Cloud with Enterprise Managed Users.<br/>
        /// GitHub cannot reactivate any credentials that have been revoked; new credentials will need to be generated.<br/>
        /// To prevent abuse, this API is limited to only 60 unauthenticated requests per hour and a max of 1000 tokens per API request.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Any authenticated requests will return a 403.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CredentialsRevokeAsync(

            global::tryAGI.GitHub.CredentialsRevokeRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a list of credentials<br/>
        /// Submit a list of credentials to be revoked. This endpoint is intended to revoke credentials the caller does not own and may have found exposed on GitHub.com or elsewhere. It can also be used for credentials associated with an old user account that you no longer have access to. Credential owners will be notified of the revocation.<br/>
        /// This endpoint currently accepts the following credential types:<br/>
        /// - Personal access tokens (classic) (`ghp_`)<br/>
        /// - Fine-grained personal access tokens (`github_pat_`)<br/>
        /// - OAuth app access tokens (`gho_`)<br/>
        /// - User-to-server tokens from GitHub Apps (`ghu_`)<br/>
        /// - Refresh tokens from GitHub Apps (`ghr_`)<br/>
        /// Revoked credentials may impact users on GitHub Free, Pro, &amp; Team and GitHub Enterprise Cloud, and GitHub Enterprise Cloud with Enterprise Managed Users.<br/>
        /// GitHub cannot reactivate any credentials that have been revoked; new credentials will need to be generated.<br/>
        /// To prevent abuse, this API is limited to only 60 unauthenticated requests per hour and a max of 1000 tokens per API request.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Any authenticated requests will return a 403.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<string>> CredentialsRevokeAsResponseAsync(

            global::tryAGI.GitHub.CredentialsRevokeRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke a list of credentials<br/>
        /// Submit a list of credentials to be revoked. This endpoint is intended to revoke credentials the caller does not own and may have found exposed on GitHub.com or elsewhere. It can also be used for credentials associated with an old user account that you no longer have access to. Credential owners will be notified of the revocation.<br/>
        /// This endpoint currently accepts the following credential types:<br/>
        /// - Personal access tokens (classic) (`ghp_`)<br/>
        /// - Fine-grained personal access tokens (`github_pat_`)<br/>
        /// - OAuth app access tokens (`gho_`)<br/>
        /// - User-to-server tokens from GitHub Apps (`ghu_`)<br/>
        /// - Refresh tokens from GitHub Apps (`ghr_`)<br/>
        /// Revoked credentials may impact users on GitHub Free, Pro, &amp; Team and GitHub Enterprise Cloud, and GitHub Enterprise Cloud with Enterprise Managed Users.<br/>
        /// GitHub cannot reactivate any credentials that have been revoked; new credentials will need to be generated.<br/>
        /// To prevent abuse, this API is limited to only 60 unauthenticated requests per hour and a max of 1000 tokens per API request.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Any authenticated requests will return a 403.
        /// </summary>
        /// <param name="credentials">
        /// A list of credentials to be revoked, up to 1000 per request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CredentialsRevokeAsync(
            global::System.Collections.Generic.IList<string> credentials,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}