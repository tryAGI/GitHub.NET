#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List repositories accessible to the user access token<br/>
        /// List repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access for an installation.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.<br/>
        /// The access the user has to each repository is included in the hash under the `permissions` key.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AppsListInstallationReposForAuthenticatedUserResponse> AppsListInstallationReposForAuthenticatedUserAsync(
            int installationId,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories accessible to the user access token<br/>
        /// List repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access for an installation.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.<br/>
        /// The access the user has to each repository is included in the hash under the `permissions` key.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AppsListInstallationReposForAuthenticatedUserResponse>> AppsListInstallationReposForAuthenticatedUserAsResponseAsync(
            int installationId,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AppsListInstallationReposForAuthenticatedUserAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.AllOf&lt;global::tryAGI.GitHub.Repository, global::tryAGI.GitHub.AppsListInstallationReposForAuthenticatedUserResponseRepositorie&gt;&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.Repository, global::tryAGI.GitHub.AppsListInstallationReposForAuthenticatedUserResponseRepositorie>> AppsListInstallationReposForAuthenticatedUserAutoPagingAsync(
            int installationId,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}