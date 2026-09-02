#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Get default attributes for a codespace<br/>
        /// Gets the default attributes for codespaces created by the user with the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="clientIp">
        /// Example: 1.2.3.4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodespacesPreFlightWithRepoForAuthenticatedUserResponse> CodespacesPreFlightWithRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            string? @ref = default,
            string? clientIp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get default attributes for a codespace<br/>
        /// Gets the default attributes for codespaces created by the user with the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="clientIp">
        /// Example: 1.2.3.4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodespacesPreFlightWithRepoForAuthenticatedUserResponse>> CodespacesPreFlightWithRepoForAuthenticatedUserAsResponseAsync(
            string owner,
            string repo,
            string? @ref = default,
            string? clientIp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}