#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Remove pull requests from a pull request stack<br/>
        /// Removes the unmerged pull requests from a stack. Pull requests that cannot be<br/>
        /// unstacked (for example, those that are queued for merge) are left in place. When pull requests remain in the stack, the updated<br/>
        /// stack is returned with a `200`. When no pull requests remain, the stack is<br/>
        /// dissolved and a `204` is returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="stackNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestStacksUnstackResponse> PullRequestStacksUnstackAsync(
            string owner,
            string repo,
            int stackNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove pull requests from a pull request stack<br/>
        /// Removes the unmerged pull requests from a stack. Pull requests that cannot be<br/>
        /// unstacked (for example, those that are queued for merge) are left in place. When pull requests remain in the stack, the updated<br/>
        /// stack is returned with a `200`. When no pull requests remain, the stack is<br/>
        /// dissolved and a `204` is returned.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="stackNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestStacksUnstackResponse>> PullRequestStacksUnstackAsResponseAsync(
            string owner,
            string repo,
            int stackNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}