#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List repositories accessible to the app installation<br/>
        /// List repositories that an app installation can access.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AppsListReposAccessibleToInstallationResponse> AppsListReposAccessibleToInstallationAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories accessible to the app installation<br/>
        /// List repositories that an app installation can access.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AppsListReposAccessibleToInstallationResponse>> AppsListReposAccessibleToInstallationAsResponseAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AppsListReposAccessibleToInstallationAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.AllOf&lt;global::tryAGI.GitHub.Repository, global::tryAGI.GitHub.AppsListReposAccessibleToInstallationResponseRepositorie&gt;&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.Repository, global::tryAGI.GitHub.AppsListReposAccessibleToInstallationResponseRepositorie>> AppsListReposAccessibleToInstallationAutoPagingAsync(
              int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}