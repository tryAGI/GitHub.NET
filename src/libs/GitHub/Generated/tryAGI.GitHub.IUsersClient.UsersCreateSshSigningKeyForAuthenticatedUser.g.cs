#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a SSH signing key for the authenticated user<br/>
        /// Creates an SSH signing key for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SshSigningKey> UsersCreateSshSigningKeyForAuthenticatedUserAsync(

            global::tryAGI.GitHub.UsersCreateSshSigningKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SSH signing key for the authenticated user<br/>
        /// Creates an SSH signing key for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SshSigningKey>> UsersCreateSshSigningKeyForAuthenticatedUserAsResponseAsync(

            global::tryAGI.GitHub.UsersCreateSshSigningKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SSH signing key for the authenticated user<br/>
        /// Creates an SSH signing key for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="title">
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </param>
        /// <param name="key">
        /// The public SSH key to add to your GitHub account. For more information, see "[Checking for existing SSH keys](https://docs.github.com/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)."
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SshSigningKey> UsersCreateSshSigningKeyForAuthenticatedUserAsync(
            string key,
            string? title = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}