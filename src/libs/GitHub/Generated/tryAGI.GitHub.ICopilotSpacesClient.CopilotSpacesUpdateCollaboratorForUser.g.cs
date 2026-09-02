#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set a collaborator role for a Copilot Space for a user<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesUpdateCollaboratorForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserActorType actorType,
            string actorIdentifier,

            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a collaborator role for a Copilot Space for a user<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceCollaborator>> CopilotSpacesUpdateCollaboratorForUserAsResponseAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserActorType actorType,
            string actorIdentifier,

            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a collaborator role for a Copilot Space for a user<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="role">
        /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesUpdateCollaboratorForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForUserRequestRole role,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}