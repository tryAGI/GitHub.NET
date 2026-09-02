#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// List collaborators for a Copilot Space for a user<br/>
        /// Lists all collaborators for a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// Each collaborator entry specifies which user has access to the space and at what level (reader, writer, or admin). The space owner is excluded from this list.<br/>
        /// Team collaborators are not supported for user-owned Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpacesListCollaboratorsForUserResponse> CopilotSpacesListCollaboratorsForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List collaborators for a Copilot Space for a user<br/>
        /// Lists all collaborators for a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// Each collaborator entry specifies which user has access to the space and at what level (reader, writer, or admin). The space owner is excluded from this list.<br/>
        /// Team collaborators are not supported for user-owned Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpacesListCollaboratorsForUserResponse>> CopilotSpacesListCollaboratorsForUserAsResponseAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}