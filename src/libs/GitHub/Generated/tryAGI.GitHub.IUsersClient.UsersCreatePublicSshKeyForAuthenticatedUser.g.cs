#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a public SSH key for the authenticated user<br/>
        /// Adds a public SSH key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Key> UsersCreatePublicSshKeyForAuthenticatedUserAsync(

            global::tryAGI.GitHub.UsersCreatePublicSshKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a public SSH key for the authenticated user<br/>
        /// Adds a public SSH key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Key>> UsersCreatePublicSshKeyForAuthenticatedUserAsResponseAsync(

            global::tryAGI.GitHub.UsersCreatePublicSshKeyForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a public SSH key for the authenticated user<br/>
        /// Adds a public SSH key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="title">
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </param>
        /// <param name="key">
        /// The public SSH key to add to your GitHub account.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Key> UsersCreatePublicSshKeyForAuthenticatedUserAsync(
            string key,
            string? title = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}