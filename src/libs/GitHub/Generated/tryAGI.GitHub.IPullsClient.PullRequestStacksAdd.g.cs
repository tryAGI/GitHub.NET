#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Add pull requests to a pull request stack<br/>
        /// Appends an ordered list of pull request numbers onto the top of an existing<br/>
        /// stack. Provide only the pull requests you want to add, from the current top of<br/>
        /// the stack upward. The first new pull request's base ref must match the current<br/>
        /// top pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="stackNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestStacksAddResponse> PullRequestStacksAddAsync(
            string owner,
            string repo,
            int stackNumber,

            global::tryAGI.GitHub.PullRequestStacksAddRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add pull requests to a pull request stack<br/>
        /// Appends an ordered list of pull request numbers onto the top of an existing<br/>
        /// stack. Provide only the pull requests you want to add, from the current top of<br/>
        /// the stack upward. The first new pull request's base ref must match the current<br/>
        /// top pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="stackNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestStacksAddResponse>> PullRequestStacksAddAsResponseAsync(
            string owner,
            string repo,
            int stackNumber,

            global::tryAGI.GitHub.PullRequestStacksAddRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add pull requests to a pull request stack<br/>
        /// Appends an ordered list of pull request numbers onto the top of an existing<br/>
        /// stack. Provide only the pull requests you want to add, from the current top of<br/>
        /// the stack upward. The first new pull request's base ref must match the current<br/>
        /// top pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="stackNumber"></param>
        /// <param name="pullRequests">
        /// An ordered list of pull request numbers to append to the stack, from the current top upward.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestStacksAddResponse> PullRequestStacksAddAsync(
            string owner,
            string repo,
            int stackNumber,
            global::System.Collections.Generic.IList<int> pullRequests,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}