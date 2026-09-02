#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List repositories with GitHub Actions cache usage for an organization<br/>
        /// Lists repositories and their GitHub Actions cache usage for an organization.<br/>
        /// The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsGetActionsCacheUsageByRepoForOrgResponse> ActionsGetActionsCacheUsageByRepoForOrgAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories with GitHub Actions cache usage for an organization<br/>
        /// Lists repositories and their GitHub Actions cache usage for an organization.<br/>
        /// The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsGetActionsCacheUsageByRepoForOrgResponse>> ActionsGetActionsCacheUsageByRepoForOrgAsResponseAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ActionsGetActionsCacheUsageByRepoForOrgAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.ActionsCacheUsageByRepository&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.ActionsCacheUsageByRepository> ActionsGetActionsCacheUsageByRepoForOrgAutoPagingAsync(
            string org,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}