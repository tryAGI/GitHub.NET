#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Add a collaborator to a Copilot Space for a user<br/>
        /// Adds a collaborator to a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// Team collaborators are not supported for user-owned Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesAddCollaboratorForUserAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a collaborator to a Copilot Space for a user<br/>
        /// Adds a collaborator to a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// Team collaborators are not supported for user-owned Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceCollaborator>> CopilotSpacesAddCollaboratorForUserAsResponseAsync(
            string username,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a collaborator to a Copilot Space for a user<br/>
        /// Adds a collaborator to a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// Team collaborators are not supported for user-owned Copilot Spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType">
        /// The type of actor (must be `User` for user-owned spaces; `Team` will be rejected).
        /// </param>
        /// <param name="actorIdentifier">
        /// The username of the collaborator. The numeric user ID is also accepted.
        /// </param>
        /// <param name="role">
        /// The role to grant to the collaborator.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesAddCollaboratorForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForUserRequestRole role,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}