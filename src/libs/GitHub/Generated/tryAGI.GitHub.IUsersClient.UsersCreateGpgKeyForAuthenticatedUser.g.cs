#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a GPG key for the authenticated user<br/>
        /// Adds a GPG key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.GpgKey> UsersCreateGpgKeyForAuthenticatedUserAsync(

            global::tryAGI.GitHub.UsersCreateGpgKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GPG key for the authenticated user<br/>
        /// Adds a GPG key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.GpgKey>> UsersCreateGpgKeyForAuthenticatedUserAsResponseAsync(

            global::tryAGI.GitHub.UsersCreateGpgKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a GPG key for the authenticated user<br/>
        /// Adds a GPG key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="name">
        /// A descriptive name for the new key.
        /// </param>
        /// <param name="armoredPublicKey">
        /// A GPG key in ASCII-armored format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.GpgKey> UsersCreateGpgKeyForAuthenticatedUserAsync(
            string armoredPublicKey,
            string? name = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}