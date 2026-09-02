#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IEnterpriseTeamOrganizationsClient
    {
        /// <summary>
        /// Add organization assignments<br/>
        /// Assign an enterprise team to multiple organizations.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSimple>> EnterpriseTeamOrganizationsBulkAddAsync(
            string enterprise,
            string enterpriseTeam,

            global::tryAGI.GitHub.EnterpriseTeamOrganizationsBulkAddRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add organization assignments<br/>
        /// Assign an enterprise team to multiple organizations.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSimple>>> EnterpriseTeamOrganizationsBulkAddAsResponseAsync(
            string enterprise,
            string enterpriseTeam,

            global::tryAGI.GitHub.EnterpriseTeamOrganizationsBulkAddRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add organization assignments<br/>
        /// Assign an enterprise team to multiple organizations.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="organizationSlugs">
        /// Organization slug to assign the team to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.OrganizationSimple>> EnterpriseTeamOrganizationsBulkAddAsync(
            string enterprise,
            string enterpriseTeam,
            global::System.Collections.Generic.IList<string> organizationSlugs,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}