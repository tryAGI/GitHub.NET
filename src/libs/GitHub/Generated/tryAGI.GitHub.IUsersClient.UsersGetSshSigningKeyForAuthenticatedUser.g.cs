#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get an SSH signing key for the authenticated user<br/>
        /// Gets extended details for an SSH signing key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SshSigningKey> UsersGetSshSigningKeyForAuthenticatedUserAsync(
            int sshSigningKeyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an SSH signing key for the authenticated user<br/>
        /// Gets extended details for an SSH signing key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SshSigningKey>> UsersGetSshSigningKeyForAuthenticatedUserAsResponseAsync(
            int sshSigningKeyId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}