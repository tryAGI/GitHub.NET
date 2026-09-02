#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamMembershipsClient
    {
        /// <summary>
        /// Bulk remove team members<br/>
        /// Remove multiple team members from an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkRemoveAsync(
            string enterprise,
            string enterpriseTeam,

            global::tryAGI.GitHub.EnterpriseTeamMembershipsBulkRemoveRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk remove team members<br/>
        /// Remove multiple team members from an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>>> EnterpriseTeamMembershipsBulkRemoveAsResponseAsync(
            string enterprise,
            string enterpriseTeam,

            global::tryAGI.GitHub.EnterpriseTeamMembershipsBulkRemoveRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk remove team members<br/>
        /// Remove multiple team members from an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="usernames">
        /// The GitHub user handles to be removed from the team.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkRemoveAsync(
            string enterprise,
            string enterpriseTeam,
            global::System.Collections.Generic.IList<string> usernames,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}