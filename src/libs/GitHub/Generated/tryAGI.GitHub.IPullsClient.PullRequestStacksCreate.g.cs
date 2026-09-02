#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Create a pull request stack<br/>
        /// Creates a stack from an ordered list of pull request numbers. Provide the pull<br/>
        /// request numbers from the bottom of the stack to the top. Each pull request's<br/>
        /// base ref must match the previous pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestStacksCreateResponse> PullRequestStacksCreateAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.PullRequestStacksCreateRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pull request stack<br/>
        /// Creates a stack from an ordered list of pull request numbers. Provide the pull<br/>
        /// request numbers from the bottom of the stack to the top. Each pull request's<br/>
        /// base ref must match the previous pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestStacksCreateResponse>> PullRequestStacksCreateAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.PullRequestStacksCreateRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a pull request stack<br/>
        /// Creates a stack from an ordered list of pull request numbers. Provide the pull<br/>
        /// request numbers from the bottom of the stack to the top. Each pull request's<br/>
        /// base ref must match the previous pull request's head ref.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullRequests">
        /// An ordered list of pull request numbers forming the stack from bottom to top.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestStacksCreateResponse> PullRequestStacksCreateAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<int> pullRequests,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}