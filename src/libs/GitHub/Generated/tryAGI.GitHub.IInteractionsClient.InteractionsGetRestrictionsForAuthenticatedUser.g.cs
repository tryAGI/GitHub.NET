#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get interaction restrictions for your public repositories<br/>
        /// Shows which type of GitHub user can interact with your public repositories and when the restriction expires.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.InteractionLimitResponse, global::tryAGI.GitHub.InteractionsGetRestrictionsForAuthenticatedUserResponse2>> InteractionsGetRestrictionsForAuthenticatedUserAsync(
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get interaction restrictions for your public repositories<br/>
        /// Shows which type of GitHub user can interact with your public repositories and when the restriction expires.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.InteractionLimitResponse, global::tryAGI.GitHub.InteractionsGetRestrictionsForAuthenticatedUserResponse2>>> InteractionsGetRestrictionsForAuthenticatedUserAsResponseAsync(
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}