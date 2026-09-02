#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Create an organization Copilot Space<br/>
        /// Creates a new Copilot Space owned by an organization. The authenticated user must have permissions to create spaces in the organization.<br/>
        /// Organization members with appropriate permissions can create Copilot Spaces to be shared within their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by the submitted resources.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesCreateForOrgAsync(
            string org,

            global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an organization Copilot Space<br/>
        /// Creates a new Copilot Space owned by an organization. The authenticated user must have permissions to create spaces in the organization.<br/>
        /// Organization members with appropriate permissions can create Copilot Spaces to be shared within their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by the submitted resources.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpace>> CopilotSpacesCreateForOrgAsResponseAsync(
            string org,

            global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an organization Copilot Space<br/>
        /// Creates a new Copilot Space owned by an organization. The authenticated user must have permissions to create spaces in the organization.<br/>
        /// Organization members with appropriate permissions can create Copilot Spaces to be shared within their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by the submitted resources.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: Team Planning Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Organization space for team planning and coordination
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Help the team with planning and coordination tasks
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for organization members.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Organization members can read the space<br/>
        /// - `writer`: Organization members can read and edit the space<br/>
        /// - `admin`: Organization members have full admin access to the space<br/>
        /// Default Value: no_access
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesCreateForOrgAsync(
            string org,
            string name,
            string? description = default,
            string? generalInstructions = default,
            global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestBaseRole? baseRole = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesCreateForOrgRequestResourcesAttribute>? resourcesAttributes = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}