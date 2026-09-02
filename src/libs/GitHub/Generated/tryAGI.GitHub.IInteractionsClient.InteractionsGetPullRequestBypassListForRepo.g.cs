#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get pull request creation cap bypass list for a repository<br/>
        /// Lists the users that are on the pull request creation cap bypass list for a<br/>
        /// repository. Users on this list can create pull requests regardless of any<br/>
        /// configured pull request creation cap.<br/>
        /// Only users with maintainer permissions can view the bypass list.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>> InteractionsGetPullRequestBypassListForRepoAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get pull request creation cap bypass list for a repository<br/>
        /// Lists the users that are on the pull request creation cap bypass list for a<br/>
        /// repository. Users on this list can create pull requests regardless of any<br/>
        /// configured pull request creation cap.<br/>
        /// Only users with maintainer permissions can view the bypass list.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>>> InteractionsGetPullRequestBypassListForRepoAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}