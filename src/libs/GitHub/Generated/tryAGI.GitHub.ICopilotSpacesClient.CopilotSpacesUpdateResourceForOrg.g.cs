#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set a resource for an organization Copilot Space<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by an organization.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including the resource being updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesUpdateResourceForOrgAsync(
            string org,
            int spaceNumber,
            int spaceResourceId,

            global::tryAGI.GitHub.CopilotSpacesUpdateResourceForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a resource for an organization Copilot Space<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by an organization.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including the resource being updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceResource>> CopilotSpacesUpdateResourceForOrgAsResponseAsync(
            string org,
            int spaceNumber,
            int spaceResourceId,

            global::tryAGI.GitHub.CopilotSpacesUpdateResourceForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a resource for an organization Copilot Space<br/>
        /// Updates the metadata of a resource in a specific Copilot Space owned by an organization.<br/>
        /// The authenticated user must have write permissions on the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space, including the resource being updated.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="spaceResourceId"></param>
        /// <param name="metadata">
        /// Updated resource-specific metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceResource> CopilotSpacesUpdateResourceForOrgAsync(
            string org,
            int spaceNumber,
            int spaceResourceId,
            object? metadata = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}