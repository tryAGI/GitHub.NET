#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the combined status for a specific reference<br/>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.<br/>
        /// Additionally, a combined `state` is returned. The `state` is one of:<br/>
        /// *   **failure** if any of the contexts report as `error` or `failure`<br/>
        /// *   **pending** if there are no statuses or a context is `pending`<br/>
        /// *   **success** if the latest status for all contexts is `success`
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CombinedCommitStatus> ReposGetCombinedStatusForRefAsync(
            string owner,
            string repo,
            string @ref,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the combined status for a specific reference<br/>
        /// Users with pull access in a repository can access a combined view of commit statuses for a given ref. The ref can be a SHA, a branch name, or a tag name.<br/>
        /// Additionally, a combined `state` is returned. The `state` is one of:<br/>
        /// *   **failure** if any of the contexts report as `error` or `failure`<br/>
        /// *   **pending** if there are no statuses or a context is `pending`<br/>
        /// *   **success** if the latest status for all contexts is `success`
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CombinedCommitStatus>> ReposGetCombinedStatusForRefAsResponseAsync(
            string owner,
            string repo,
            string @ref,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ReposGetCombinedStatusForRefAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.SimpleCommitStatus&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.SimpleCommitStatus> ReposGetCombinedStatusForRefAutoPagingAsync(
            string owner,
            string repo,
            string @ref,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}