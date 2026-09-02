#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repositories for the authenticated user<br/>
        /// Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">
        /// Default Value: all
        /// </param>
        /// <param name="affiliation">
        /// Default Value: owner,collaborator,organization_member
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Repository>> ReposListForAuthenticatedUserAsync(
            global::tryAGI.GitHub.ReposListForAuthenticatedUserVisibility? visibility = default,
            string? affiliation = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserType? type = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserSort? sort = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories for the authenticated user<br/>
        /// Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">
        /// Default Value: all
        /// </param>
        /// <param name="affiliation">
        /// Default Value: owner,collaborator,organization_member
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Repository>>> ReposListForAuthenticatedUserAsResponseAsync(
            global::tryAGI.GitHub.ReposListForAuthenticatedUserVisibility? visibility = default,
            string? affiliation = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserType? type = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserSort? sort = default,
            global::tryAGI.GitHub.ReposListForAuthenticatedUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}