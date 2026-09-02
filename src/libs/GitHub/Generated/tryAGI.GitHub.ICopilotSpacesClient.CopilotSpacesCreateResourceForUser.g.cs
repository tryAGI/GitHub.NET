#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Create a resource for a Copilot Space for a user<br/>
        /// Creates a new resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// The following resource types are supported: `repository`, `github_file`, `free_text`, `github_issue`, `github_pull_request`.<br/>
        /// The `uploaded_text_file` and `media_content` types are not supported via this endpoint.<br/>
        /// For `github_file` resources, if a resource with the same repository, file path, and SHA already exists, the existing resource is returned with a `200` status.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesCreateResourceForUserAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesCreateResourceForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a resource for a Copilot Space for a user<br/>
        /// Creates a new resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// The following resource types are supported: `repository`, `github_file`, `free_text`, `github_issue`, `github_pull_request`.<br/>
        /// The `uploaded_text_file` and `media_content` types are not supported via this endpoint.<br/>
        /// For `github_file` resources, if a resource with the same repository, file path, and SHA already exists, the existing resource is returned with a `200` status.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceResource>> CopilotSpacesCreateResourceForUserAsResponseAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesCreateResourceForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a resource for a Copilot Space for a user<br/>
        /// Creates a new resource in a specific Copilot Space owned by a user.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// The following resource types are supported: `repository`, `github_file`, `free_text`, `github_issue`, `github_pull_request`.<br/>
        /// The `uploaded_text_file` and `media_content` types are not supported via this endpoint.<br/>
        /// For `github_file` resources, if a resource with the same repository, file path, and SHA already exists, the existing resource is returned with a `200` status.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="resourceType">
        /// The type of resource to create.
        /// </param>
        /// <param name="metadata">
        /// Resource-specific metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesCreateResourceForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesCreateResourceForUserRequestResourceType resourceType,
            object metadata,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}