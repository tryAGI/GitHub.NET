#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// List check suites for a Git reference<br/>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="appId"></param>
        /// <param name="checkName"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ChecksListSuitesForRefResponse> ChecksListSuitesForRefAsync(
            string owner,
            string repo,
            string @ref,
            int? appId = default,
            string? checkName = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List check suites for a Git reference<br/>
        /// Lists check suites for a commit `ref`. The `ref` can be a SHA, branch name, or a tag name.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="appId"></param>
        /// <param name="checkName"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ChecksListSuitesForRefResponse>> ChecksListSuitesForRefAsResponseAsync(
            string owner,
            string repo,
            string @ref,
            int? appId = default,
            string? checkName = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ChecksListSuitesForRefAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.CheckSuite&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="appId"></param>
        /// <param name="checkName"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.CheckSuite> ChecksListSuitesForRefAutoPagingAsync(
            string owner,
            string repo,
            string @ref,             int? appId = default,
            string? checkName = default,
            int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}