#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Get a resource for a Copilot Space for a user<br/>
        /// Gets a specific resource attached to a Copilot Space owned by a user.<br/>
        /// The authenticated user must have appropriate permissions to view the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesGetResourceForUserAsync(
            string username,
            int spaceNumber,
            int spaceResourceId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a resource for a Copilot Space for a user<br/>
        /// Gets a specific resource attached to a Copilot Space owned by a user.<br/>
        /// The authenticated user must have appropriate permissions to view the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceResource>> CopilotSpacesGetResourceForUserAsResponseAsync(
            string username,
            int spaceNumber,
            int spaceResourceId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}