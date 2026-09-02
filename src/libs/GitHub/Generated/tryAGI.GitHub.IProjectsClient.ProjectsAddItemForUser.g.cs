#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add item to user owned project<br/>
        /// Add an issue or pull request item to the specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemSimple> ProjectsAddItemForUserAsync(
            string username,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsAddItemForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add item to user owned project<br/>
        /// Add an issue or pull request item to the specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2ItemSimple>> ProjectsAddItemForUserAsResponseAsync(
            string username,
            int projectNumber,

            global::tryAGI.GitHub.ProjectsAddItemForUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add item to user owned project<br/>
        /// Add an issue or pull request item to the specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="type">
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the issue or pull request to add to the project.
        /// </param>
        /// <param name="owner">
        /// The repository owner login.
        /// </param>
        /// <param name="repo">
        /// The repository name.
        /// </param>
        /// <param name="number">
        /// The issue or pull request number.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemSimple> ProjectsAddItemForUserAsync(
            string username,
            int projectNumber,
            global::tryAGI.GitHub.ProjectsAddItemForUserRequestType type,
            int? id = default,
            string? owner = default,
            string? repo = default,
            int? number = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}