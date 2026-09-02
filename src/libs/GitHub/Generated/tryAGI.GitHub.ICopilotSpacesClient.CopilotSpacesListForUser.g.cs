#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// List Copilot Spaces for a user<br/>
        /// Lists Copilot Spaces owned by a user. The authenticated user must have read access to the user's Copilot Spaces.<br/>
        /// Only Spaces that are readable by the authenticated user are returned. This includes the user's own spaces, and public user spaces when accessing another user's spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpacesListForUserResponse> CopilotSpacesListForUserAsync(
            string username,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Copilot Spaces for a user<br/>
        /// Lists Copilot Spaces owned by a user. The authenticated user must have read access to the user's Copilot Spaces.<br/>
        /// Only Spaces that are readable by the authenticated user are returned. This includes the user's own spaces, and public user spaces when accessing another user's spaces.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:user` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpacesListForUserResponse>> CopilotSpacesListForUserAsResponseAsync(
            string username,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}