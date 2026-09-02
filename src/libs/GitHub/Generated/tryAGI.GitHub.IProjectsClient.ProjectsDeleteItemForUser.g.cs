#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project item for user<br/>
        /// Delete a specific item from a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsDeleteItemForUserAsync(
            int projectNumber,
            string username,
            int itemId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete project item for user<br/>
        /// Delete a specific item from a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ProjectsDeleteItemForUserAsResponseAsync(
            int projectNumber,
            string username,
            int itemId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}