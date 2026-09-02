#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List app installations for an organization<br/>
        /// Lists all GitHub Apps in an organization. The installation count includes<br/>
        /// all GitHub Apps installed on repositories in the organization.<br/>
        /// The authenticated user must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:read` scope to use this endpoint.
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsListAppInstallationsResponse> OrgsListAppInstallationsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List app installations for an organization<br/>
        /// Lists all GitHub Apps in an organization. The installation count includes<br/>
        /// all GitHub Apps installed on repositories in the organization.<br/>
        /// The authenticated user must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:read` scope to use this endpoint.
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsListAppInstallationsResponse>> OrgsListAppInstallationsAsResponseAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps OrgsListAppInstallationsAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.Installation&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.Installation> OrgsListAppInstallationsAutoPagingAsync(
            string org,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}