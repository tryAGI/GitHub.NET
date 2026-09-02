#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Remove a collaborator from a Copilot Space for a user<br/>
        /// Removes a collaborator from a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSpacesRemoveCollaboratorForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesRemoveCollaboratorForUserActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a collaborator from a Copilot Space for a user<br/>
        /// Removes a collaborator from a specific Copilot Space owned by a user. The authenticated user must be the owner of the space or have admin access to the space.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSpacesRemoveCollaboratorForUserAsResponseAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesRemoveCollaboratorForUserActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}