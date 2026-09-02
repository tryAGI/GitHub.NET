#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Add a collaborator to an organization Copilot Space<br/>
        /// Adds a collaborator (user or team) to a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// **Note:** When adding users as collaborators, they must already be members of the organization.<br/>
        /// When adding teams as collaborators, they must be defined in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesAddCollaboratorForOrgAsync(
            string org,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a collaborator to an organization Copilot Space<br/>
        /// Adds a collaborator (user or team) to a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// **Note:** When adding users as collaborators, they must already be members of the organization.<br/>
        /// When adding teams as collaborators, they must be defined in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpaceCollaborator>> CopilotSpacesAddCollaboratorForOrgAsResponseAsync(
            string org,
            int spaceNumber,

            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a collaborator to an organization Copilot Space<br/>
        /// Adds a collaborator (user or team) to a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to manage collaborators.<br/>
        /// **Note:** When adding users as collaborators, they must already be members of the organization.<br/>
        /// When adding teams as collaborators, they must be defined in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="actorType">
        /// The type of actor (user or team).
        /// </param>
        /// <param name="actorIdentifier">
        /// The username (for users) or team slug (for teams). The numeric ID of a user or team is also accepted.
        /// </param>
        /// <param name="role">
        /// The role to grant to the collaborator.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpaceCollaborator> CopilotSpacesAddCollaboratorForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestActorType actorType,
            string actorIdentifier,
            global::tryAGI.GitHub.CopilotSpacesAddCollaboratorForOrgRequestRole role,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}