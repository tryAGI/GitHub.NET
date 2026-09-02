#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamOrganizationsClient
    {
        /// <summary>
        /// Delete an organization assignment<br/>
        /// Unassign an enterprise team from an organization.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task EnterpriseTeamOrganizationsDeleteAsync(
            string enterprise,
            string enterpriseTeam,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an organization assignment<br/>
        /// Unassign an enterprise team from an organization.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> EnterpriseTeamOrganizationsDeleteAsResponseAsync(
            string enterprise,
            string enterpriseTeam,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}