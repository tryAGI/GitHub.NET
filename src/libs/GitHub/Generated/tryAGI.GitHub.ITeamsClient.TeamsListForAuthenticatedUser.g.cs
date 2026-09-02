#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List teams for the authenticated user<br/>
        /// List all of the teams across all of the organizations to which the authenticated<br/>
        /// user belongs.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user`, `repo`, or `read:org` scope to use this endpoint.<br/>
        /// When using a fine-grained personal access token, the resource owner of the token must be a single organization, and the response will only include the teams from that organization.
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.TeamFull>> TeamsListForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List teams for the authenticated user<br/>
        /// List all of the teams across all of the organizations to which the authenticated<br/>
        /// user belongs.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user`, `repo`, or `read:org` scope to use this endpoint.<br/>
        /// When using a fine-grained personal access token, the resource owner of the token must be a single organization, and the response will only include the teams from that organization.
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.TeamFull>>> TeamsListForAuthenticatedUserAsResponseAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}