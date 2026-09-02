#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add field to user owned project<br/>
        /// Add a field to a specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2Field> ProjectsAddFieldForUserAsync(
            string username,
            int projectNumber,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant1, global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant2, global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant3> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add field to user owned project<br/>
        /// Add a field to a specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2Field>> ProjectsAddFieldForUserAsResponseAsync(
            string username,
            int projectNumber,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant1, global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant2, global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant3> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add field to user owned project<br/>
        /// Add a field to a specified user owned project.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="projectNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2Field> ProjectsAddFieldForUserAsync(
            string username,
            int projectNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}