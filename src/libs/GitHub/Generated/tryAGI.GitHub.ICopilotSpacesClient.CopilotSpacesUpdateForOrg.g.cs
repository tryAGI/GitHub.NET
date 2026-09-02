#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set an organization Copilot Space<br/>
        /// Updates a Copilot Space owned by an organization. The authenticated user must have permissions to update spaces in the organization.<br/>
        /// Organization members with appropriate permissions can update Copilot Spaces owned by their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including any being added or updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesUpdateForOrgAsync(
            string org,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an organization Copilot Space<br/>
        /// Updates a Copilot Space owned by an organization. The authenticated user must have permissions to update spaces in the organization.<br/>
        /// Organization members with appropriate permissions can update Copilot Spaces owned by their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including any being added or updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpace>> CopilotSpacesUpdateForOrgAsResponseAsync(
            string org,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an organization Copilot Space<br/>
        /// Updates a Copilot Space owned by an organization. The authenticated user must have permissions to update spaces in the organization.<br/>
        /// Organization members with appropriate permissions can update Copilot Spaces owned by their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including any being added or updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: Updated Team Planning Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Updated organization space for team planning and coordination
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Updated instructions to help the team with planning and coordination tasks
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for organization members. Changing this field requires admin permissions.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesUpdateForOrgAsync(
            string org,
            int spaceNumber,
            string? name = default,
            string? description = default,
            string? generalInstructions = default,
            global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestBaseRole? baseRole = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesUpdateForOrgRequestResourcesAttribute>? resourcesAttributes = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}