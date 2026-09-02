#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project item for user<br/>
        /// Update a specific item in a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForUserAsync(
            int projectNumber,
            string username,
            int itemId,

            global::tryAGI.GitHub.ProjectsUpdateItemForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project item for user<br/>
        /// Update a specific item in a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2ItemWithContent>> ProjectsUpdateItemForUserAsResponseAsync(
            int projectNumber,
            string username,
            int itemId,

            global::tryAGI.GitHub.ProjectsUpdateItemForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project item for user<br/>
        /// Update a specific item in a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="fields">
        /// A list of field updates to apply.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForUserAsync(
            int projectNumber,
            string username,
            int itemId,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsUpdateItemForUserRequestField> fields,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}