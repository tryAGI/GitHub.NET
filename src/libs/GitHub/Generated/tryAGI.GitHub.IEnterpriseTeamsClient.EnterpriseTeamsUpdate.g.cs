#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Update an enterprise team<br/>
        /// To edit a team, the authenticated user must be an enterprise owner.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EnterpriseTeam> EnterpriseTeamsUpdateAsync(
            string enterprise,
            string teamSlug,

            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an enterprise team<br/>
        /// To edit a team, the authenticated user must be an enterprise owner.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.EnterpriseTeam>> EnterpriseTeamsUpdateAsResponseAsync(
            string enterprise,
            string teamSlug,

            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an enterprise team<br/>
        /// To edit a team, the authenticated user must be an enterprise owner.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="name">
        /// A new name for the team.
        /// </param>
        /// <param name="description">
        /// A new description for the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="organizationSelectionType">
        /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
        /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
        /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments).<br/>
        /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team is set to. The options are:<br/>
        /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
        /// * `notifications_disabled` - no one receives notifications.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EnterpriseTeam> EnterpriseTeamsUpdateAsync(
            string enterprise,
            string teamSlug,
            string? name = default,
            string? description = default,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? syncToOrganizations = default,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestOrganizationSelectionType? organizationSelectionType = default,
            string? groupId = default,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestNotificationSetting? notificationSetting = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}