#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Remove users from the pull request creation cap bypass list for a repository<br/>
        /// Removes users from the pull request creation cap bypass list for a repository.<br/>
        /// Removed users will be subject to any configured pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can remove a maximum of 100 users per request.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task InteractionsRemovePullRequestBypassListForRepoAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionLimitPullRequestBypassList request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove users from the pull request creation cap bypass list for a repository<br/>
        /// Removes users from the pull request creation cap bypass list for a repository.<br/>
        /// Removed users will be subject to any configured pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can remove a maximum of 100 users per request.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> InteractionsRemovePullRequestBypassListForRepoAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionLimitPullRequestBypassList request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove users from the pull request creation cap bypass list for a repository<br/>
        /// Removes users from the pull request creation cap bypass list for a repository.<br/>
        /// Removed users will be subject to any configured pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can remove a maximum of 100 users per request.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="users">
        /// A list of user logins to add or remove from the bypass list.<br/>
        /// Example: [octocat, monalisa]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task InteractionsRemovePullRequestBypassListForRepoAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<string> users,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}