#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set a Copilot Space for a user<br/>
        /// Updates a Copilot Space owned by a user. Only the authenticated user can update spaces for their own account.<br/>
        /// Users can update their personal Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesUpdateForUserAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a Copilot Space for a user<br/>
        /// Updates a Copilot Space owned by a user. Only the authenticated user can update spaces for their own account.<br/>
        /// Users can update their personal Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpace>> CopilotSpacesUpdateForUserAsResponseAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a Copilot Space for a user<br/>
        /// Updates a Copilot Space owned by a user. Only the authenticated user can update spaces for their own account.<br/>
        /// Users can update their personal Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="name">
        /// The name of the Copilot Space.<br/>
        /// Example: Updated Development Space
        /// </param>
        /// <param name="description">
        /// A description of the Copilot Space.<br/>
        /// Example: Updated personal space for development assistance
        /// </param>
        /// <param name="generalInstructions">
        /// General instructions for the Copilot Space.<br/>
        /// Example: Updated instructions to help me with React development patterns and best practices
        /// </param>
        /// <param name="baseRole">
        /// The base role that determines default permissions for the space. Changing this field requires admin permissions.<br/>
        /// - `no_access`: No default access (default)<br/>
        /// - `reader`: Makes the space publicly readable<br/>
        /// Note: User spaces do not support writer or admin base roles.
        /// </param>
        /// <param name="resourcesAttributes">
        /// Resources to attach to the space.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesUpdateForUserAsync(
            string username,
            int spaceNumber,
            string? name = default,
            string? description = default,
            string? generalInstructions = default,
            global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestBaseRole? baseRole = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotSpacesUpdateForUserRequestResourcesAttribute>? resourcesAttributes = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}