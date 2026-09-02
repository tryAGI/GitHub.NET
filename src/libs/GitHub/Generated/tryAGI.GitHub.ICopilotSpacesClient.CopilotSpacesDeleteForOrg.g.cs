#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Delete an organization Copilot Space<br/>
        /// Deletes a Copilot Space owned by an organization. The authenticated user must have permissions to delete spaces in the organization.<br/>
        /// **Warning:** This action is permanent and cannot be undone. Deleting a Copilot Space will remove all associated resources and configurations.<br/>
        /// Organization members with appropriate permissions can delete Copilot Spaces owned by their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need both the `read:org` and `repo` scopes to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSpacesDeleteForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an organization Copilot Space<br/>
        /// Deletes a Copilot Space owned by an organization. The authenticated user must have permissions to delete spaces in the organization.<br/>
        /// **Warning:** This action is permanent and cannot be undone. Deleting a Copilot Space will remove all associated resources and configurations.<br/>
        /// Organization members with appropriate permissions can delete Copilot Spaces owned by their organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need both the `read:org` and `repo` scopes to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSpacesDeleteForOrgAsResponseAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}