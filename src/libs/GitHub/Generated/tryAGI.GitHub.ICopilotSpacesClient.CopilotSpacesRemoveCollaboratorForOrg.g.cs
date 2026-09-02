#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Remove a collaborator from an organization Copilot Space<br/>
        /// Removes a collaborator from a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSpacesRemoveCollaboratorForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesRemoveCollaboratorForOrgActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a collaborator from an organization Copilot Space<br/>
        /// Removes a collaborator from a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSpacesRemoveCollaboratorForOrgAsResponseAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesRemoveCollaboratorForOrgActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}