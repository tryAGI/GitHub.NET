#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get pull request creation cap for a repository<br/>
        /// Gets the pull request creation cap configuration for a repository.<br/>
        /// The cap limits the number of open pull requests a user can have at one time.<br/>
        /// Only users with admin access to the repository can view the cap configuration.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.InteractionsGetPullRequestCreationCapForRepoResponse> InteractionsGetPullRequestCreationCapForRepoAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get pull request creation cap for a repository<br/>
        /// Gets the pull request creation cap configuration for a repository.<br/>
        /// The cap limits the number of open pull requests a user can have at one time.<br/>
        /// Only users with admin access to the repository can view the cap configuration.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.InteractionsGetPullRequestCreationCapForRepoResponse>> InteractionsGetPullRequestCreationCapForRepoAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}