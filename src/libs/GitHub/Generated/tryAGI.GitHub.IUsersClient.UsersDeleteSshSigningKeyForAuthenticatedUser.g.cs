#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete an SSH signing key for the authenticated user<br/>
        /// Deletes an SSH signing key from the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteSshSigningKeyForAuthenticatedUserAsync(
            int sshSigningKeyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an SSH signing key for the authenticated user<br/>
        /// Deletes an SSH signing key from the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> UsersDeleteSshSigningKeyForAuthenticatedUserAsResponseAsync(
            int sshSigningKeyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}