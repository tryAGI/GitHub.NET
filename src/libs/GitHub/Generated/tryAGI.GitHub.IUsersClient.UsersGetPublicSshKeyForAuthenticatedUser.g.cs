#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get a public SSH key for the authenticated user<br/>
        /// View extended details for a single public SSH key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Key> UsersGetPublicSshKeyForAuthenticatedUserAsync(
            int keyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a public SSH key for the authenticated user<br/>
        /// View extended details for a single public SSH key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Key>> UsersGetPublicSshKeyForAuthenticatedUserAsResponseAsync(
            int keyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}