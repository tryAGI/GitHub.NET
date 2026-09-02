#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Delete an app token<br/>
        /// OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task AppsDeleteTokenAsync(
            string clientId,

            global::tryAGI.GitHub.AppsDeleteTokenRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an app token<br/>
        /// OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> AppsDeleteTokenAsResponseAsync(
            string clientId,

            global::tryAGI.GitHub.AppsDeleteTokenRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an app token<br/>
        /// OAuth  or GitHub application owners can revoke a single token for an OAuth application or a GitHub application with an OAuth authorization.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The OAuth access token used to authenticate to the GitHub API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AppsDeleteTokenAsync(
            string clientId,
            string accessToken,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}