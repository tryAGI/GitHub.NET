#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a team<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,

            global::tryAGI.GitHub.TeamsUpdateInOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.TeamFull>> TeamsUpdateInOrgAsResponseAsync(
            string org,
            string teamSlug,

            global::tryAGI.GitHub.TeamsUpdateInOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `PATCH /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
        /// </param>
        /// <param name="permission">
        /// **Closing down notice**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </param>
        /// <param name="parentTeamId">
        /// The ID of a team to set as the parent team.
        /// </param>
        /// <param name="parentTeamSlug">
        /// The slug of a team to set as the parent team. Ignored when `parent_team_id` is also provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.TeamFull> TeamsUpdateInOrgAsync(
            string org,
            string teamSlug,
            string? name = default,
            string? description = default,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestPrivacy? privacy = default,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestNotificationSetting? notificationSetting = default,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestPermission? permission = default,
            int? parentTeamId = default,
            string? parentTeamSlug = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}