#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get an organization role<br/>
        /// Gets an organization role that is available to this organization. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - An organization member (or a member of a team) assigned a custom organization role that includes the **View organization roles** (`read_organization_custom_org_role`) permission. For more information, see "[Permissions for organization access](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/permissions-of-custom-organization-roles#permissions-for-organization-access)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrganizationRole> OrgsGetOrgRoleAsync(
            string org,
            int roleId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an organization role<br/>
        /// Gets an organization role that is available to this organization. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - An organization member (or a member of a team) assigned a custom organization role that includes the **View organization roles** (`read_organization_custom_org_role`) permission. For more information, see "[Permissions for organization access](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/permissions-of-custom-organization-roles#permissions-for-organization-access)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrganizationRole>> OrgsGetOrgRoleAsResponseAsync(
            string org,
            int roleId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}