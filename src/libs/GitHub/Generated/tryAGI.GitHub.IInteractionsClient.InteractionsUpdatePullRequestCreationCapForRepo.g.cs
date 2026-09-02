#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Update pull request creation cap for a repository<br/>
        /// Updates the pull request creation cap for a repository. The cap limits the number<br/>
        /// of open pull requests a user can have at one time.<br/>
        /// Only users with admin access to the repository can configure the cap.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.InteractionsUpdatePullRequestCreationCapForRepoResponse> InteractionsUpdatePullRequestCreationCapForRepoAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionsUpdatePullRequestCreationCapForRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update pull request creation cap for a repository<br/>
        /// Updates the pull request creation cap for a repository. The cap limits the number<br/>
        /// of open pull requests a user can have at one time.<br/>
        /// Only users with admin access to the repository can configure the cap.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.InteractionsUpdatePullRequestCreationCapForRepoResponse>> InteractionsUpdatePullRequestCreationCapForRepoAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.InteractionsUpdatePullRequestCreationCapForRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update pull request creation cap for a repository<br/>
        /// Updates the pull request creation cap for a repository. The cap limits the number<br/>
        /// of open pull requests a user can have at one time.<br/>
        /// Only users with admin access to the repository can configure the cap.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="enabled">
        /// Whether the pull request creation cap is enabled
        /// </param>
        /// <param name="maxOpenPullRequests">
        /// The maximum number of open pull requests a user can have at one time
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.InteractionsUpdatePullRequestCreationCapForRepoResponse> InteractionsUpdatePullRequestCreationCapForRepoAsync(
            string owner,
            string repo,
            bool enabled,
            int? maxOpenPullRequests = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}