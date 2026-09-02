#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Remove requested reviewers from a pull request<br/>
        /// Removes review requests from a pull request for a given set of users and/or teams.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,

            global::tryAGI.GitHub.PullsRemoveRequestedReviewersRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove requested reviewers from a pull request<br/>
        /// Removes review requests from a pull request for a given set of users and/or teams.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestSimple>> PullsRemoveRequestedReviewersAsResponseAsync(
            string owner,
            string repo,
            int pullNumber,

            global::tryAGI.GitHub.PullsRemoveRequestedReviewersRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove requested reviewers from a pull request<br/>
        /// Removes review requests from a pull request for a given set of users and/or teams.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="reviewers">
        /// An array of user `login`s that will be removed.
        /// </param>
        /// <param name="teamReviewers">
        /// An array of team `slug`s that will be removed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::System.Collections.Generic.IList<string> reviewers,
            global::System.Collections.Generic.IList<string>? teamReviewers = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}