#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamMembershipsClient
    {
        /// <summary>
        /// List enterprise teams for a user<br/>
        /// Lists all enterprise teams that a user is a member of. This endpoint is available only for<br/>
        /// enterprises using the new enterprise teams experience.<br/>
        /// The authenticated user must be an enterprise owner or have the `enterprise_teams:read` permission.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.EnterpriseTeam>> EnterpriseTeamMembershipsListTeamsForUserAsync(
            string enterprise,
            string username,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List enterprise teams for a user<br/>
        /// Lists all enterprise teams that a user is a member of. This endpoint is available only for<br/>
        /// enterprises using the new enterprise teams experience.<br/>
        /// The authenticated user must be an enterprise owner or have the `enterprise_teams:read` permission.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.EnterpriseTeam>>> EnterpriseTeamMembershipsListTeamsForUserAsResponseAsync(
            string enterprise,
            string username,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}