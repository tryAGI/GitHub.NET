#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// List collaborators for an organization Copilot Space<br/>
        /// Lists all collaborators for a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to view collaborators.<br/>
        /// Each collaborator entry specifies which user or team has access to the space and at what level (reader, writer, or admin). The space owner (organization) is excluded from this list.<br/>
        /// **Note:** Team collaborators listed here are teams that are defined in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpacesListCollaboratorsForOrgResponse> CopilotSpacesListCollaboratorsForOrgAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List collaborators for an organization Copilot Space<br/>
        /// Lists all collaborators for a specific Copilot Space owned by an organization. The authenticated user must have appropriate permissions to view collaborators.<br/>
        /// Each collaborator entry specifies which user or team has access to the space and at what level (reader, writer, or admin). The space owner (organization) is excluded from this list.<br/>
        /// **Note:** Team collaborators listed here are teams that are defined in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// Fine-grained tokens and GitHub App user access tokens must have been granted access to the organization that owns the space. They must also have been granted access to every repository referenced by resources in the space.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpacesListCollaboratorsForOrgResponse>> CopilotSpacesListCollaboratorsForOrgAsResponseAsync(
            string org,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}