#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set a resource for a Copilot Space for a user<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesUpdateResourceForUserAsync(
            string username,
            int spaceNumber,
            int spaceResourceId,

            global::tryAGI.GitHub.CopilotSpacesUpdateResourceForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a resource for a Copilot Space for a user<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceResource>> CopilotSpacesUpdateResourceForUserAsResponseAsync(
            string username,
            int spaceNumber,
            int spaceResourceId,

            global::tryAGI.GitHub.CopilotSpacesUpdateResourceForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a resource for a Copilot Space for a user<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="metadata">
        /// Updated resource-specific metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesUpdateResourceForUserAsync(
            string username,
            int spaceNumber,
            int spaceResourceId,
            object? metadata = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}