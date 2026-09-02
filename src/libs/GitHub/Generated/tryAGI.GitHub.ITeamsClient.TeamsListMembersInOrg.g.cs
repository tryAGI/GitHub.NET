#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List team members<br/>
        /// Team members will include the members of child teams.<br/>
        /// Each member includes their `role` on the team (`member` or `maintainer`) and an `inherited` flag indicating whether the membership is inherited from a child team (`true`) or is a direct membership (`false`). These fields let you read a member's role and direct/inherited status without additional requests.<br/>
        /// To list members in a team, the team must be visible to the authenticated user.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/members`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.TeamMember>> TeamsListMembersInOrgAsync(
            string org,
            string teamSlug,
            global::tryAGI.GitHub.TeamsListMembersInOrgRole? role = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List team members<br/>
        /// Team members will include the members of child teams.<br/>
        /// Each member includes their `role` on the team (`member` or `maintainer`) and an `inherited` flag indicating whether the membership is inherited from a child team (`true`) or is a direct membership (`false`). These fields let you read a member's role and direct/inherited status without additional requests.<br/>
        /// To list members in a team, the team must be visible to the authenticated user.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/members`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.TeamMember>>> TeamsListMembersInOrgAsResponseAsync(
            string org,
            string teamSlug,
            global::tryAGI.GitHub.TeamsListMembersInOrgRole? role = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}