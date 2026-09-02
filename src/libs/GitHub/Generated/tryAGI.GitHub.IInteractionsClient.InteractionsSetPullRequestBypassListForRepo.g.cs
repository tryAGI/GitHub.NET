#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Add users to the pull request creation cap bypass list for a repository<br/>
        /// Adds users to the pull request creation cap bypass list for a repository.<br/>
        /// Users on this list can create pull requests regardless of any configured<br/>
        /// pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can add a maximum of 100 users per request.<br/>
        /// The bypass list can only hold a maximum of 100 users.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task InteractionsSetPullRequestBypassListForRepoAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionLimitPullRequestBypassList request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add users to the pull request creation cap bypass list for a repository<br/>
        /// Adds users to the pull request creation cap bypass list for a repository.<br/>
        /// Users on this list can create pull requests regardless of any configured<br/>
        /// pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can add a maximum of 100 users per request.<br/>
        /// The bypass list can only hold a maximum of 100 users.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> InteractionsSetPullRequestBypassListForRepoAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionLimitPullRequestBypassList request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add users to the pull request creation cap bypass list for a repository<br/>
        /// Adds users to the pull request creation cap bypass list for a repository.<br/>
        /// Users on this list can create pull requests regardless of any configured<br/>
        /// pull request creation cap.<br/>
        /// Only users with maintainer permissions can modify the bypass list.<br/>
        /// You can add a maximum of 100 users per request.<br/>
        /// The bypass list can only hold a maximum of 100 users.
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
        global::System.Threading.Tasks.Task InteractionsSetPullRequestBypassListForRepoAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<string> users,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}