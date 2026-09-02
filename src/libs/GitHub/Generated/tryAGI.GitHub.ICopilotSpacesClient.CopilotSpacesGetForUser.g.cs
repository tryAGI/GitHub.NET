#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotSpacesClient
    {
        /// <summary>
        /// Get a Copilot Space for a user<br/>
        /// Gets details about a specific Copilot Space owned by a user. The authenticated user must have read access to the Space.<br/>
        /// Private user spaces require the authenticated user to be the owner of the space.<br/>
        /// Public user spaces are accessible to any authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSpace> CopilotSpacesGetForUserAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Copilot Space for a user<br/>
        /// Gets details about a specific Copilot Space owned by a user. The authenticated user must have read access to the Space.<br/>
        /// Private user spaces require the authenticated user to be the owner of the space.<br/>
        /// Public user spaces are accessible to any authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="spaceNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSpace>> CopilotSpacesGetForUserAsResponseAsync(
            string username,
            int spaceNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}