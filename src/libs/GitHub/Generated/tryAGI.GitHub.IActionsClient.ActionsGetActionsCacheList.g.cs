#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List GitHub Actions caches for a repository<br/>
        /// Lists the GitHub Actions caches for a repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="ref"></param>
        /// <param name="key"></param>
        /// <param name="sort">
        /// Default Value: last_accessed_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsCacheList> ActionsGetActionsCacheListAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            string? @ref = default,
            string? key = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListSort? sort = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListDirection? direction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List GitHub Actions caches for a repository<br/>
        /// Lists the GitHub Actions caches for a repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="ref"></param>
        /// <param name="key"></param>
        /// <param name="sort">
        /// Default Value: last_accessed_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsCacheList>> ActionsGetActionsCacheListAsResponseAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            string? @ref = default,
            string? key = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListSort? sort = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListDirection? direction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ActionsGetActionsCacheListAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.ActionsCacheListActionsCache&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="ref"></param>
        /// <param name="key"></param>
        /// <param name="sort">
        /// Default Value: last_accessed_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.ActionsCacheListActionsCache> ActionsGetActionsCacheListAutoPagingAsync(
            string owner,
            string repo,             int? perPage = default,
            string? @ref = default,
            string? key = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListSort? sort = default,
            global::tryAGI.GitHub.ActionsGetActionsCacheListDirection? direction = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}