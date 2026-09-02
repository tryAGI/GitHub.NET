#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamOrganizationsClient
    {
        /// <summary>
        /// Get organization assignment<br/>
        /// Check if an enterprise team is assigned to an organization
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrganizationSimple> EnterpriseTeamOrganizationsGetAssignmentAsync(
            string enterprise,
            string enterpriseTeam,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization assignment<br/>
        /// Check if an enterprise team is assigned to an organization
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrganizationSimple>> EnterpriseTeamOrganizationsGetAssignmentAsResponseAsync(
            string enterprise,
            string enterpriseTeam,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}