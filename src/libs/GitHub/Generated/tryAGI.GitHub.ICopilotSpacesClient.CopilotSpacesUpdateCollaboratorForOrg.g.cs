#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Set a collaborator role for an organization Copilot Space<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesUpdateCollaboratorForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgActorType actorType,
            string actorIdentifier,

            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a collaborator role for an organization Copilot Space<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceCollaborator>> CopilotSpacesUpdateCollaboratorForOrgAsResponseAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgActorType actorType,
            string actorIdentifier,

            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a collaborator role for an organization Copilot Space<br/>
        /// Updates the role of a collaborator for a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType"></param>
        /// <param name="actorIdentifier"></param>
        /// <param name="role">
        /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesUpdateCollaboratorForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesUpdateCollaboratorForOrgRequestRole role,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}