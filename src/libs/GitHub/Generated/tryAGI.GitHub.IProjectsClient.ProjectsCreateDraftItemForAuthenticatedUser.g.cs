#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create draft item for user owned project<br/>
        /// Create draft issue item for the specified user owned project.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemSimple> ProjectsCreateDraftItemForAuthenticatedUserAsync(
            string userId,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsCreateDraftItemForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create draft item for user owned project<br/>
        /// Create draft issue item for the specified user owned project.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2ItemSimple>> ProjectsCreateDraftItemForAuthenticatedUserAsResponseAsync(
            string userId,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsCreateDraftItemForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create draft item for user owned project<br/>
        /// Create draft issue item for the specified user owned project.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="title">
        /// The title of the draft issue item to create in the project.
        /// </param>
        /// <param name="body">
        /// The body content of the draft issue item to create in the project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemSimple> ProjectsCreateDraftItemForAuthenticatedUserAsync(
            string userId,
            int projectNumber,
            string title,
            string? body = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}