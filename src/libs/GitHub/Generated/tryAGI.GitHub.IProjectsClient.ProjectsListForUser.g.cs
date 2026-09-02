#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List projects for user<br/>
        /// List all projects owned by a specific user accessible by the authenticated user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="q"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2>> ProjectsListForUserAsync(
            string username,
            string? q = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List projects for user<br/>
        /// List all projects owned by a specific user accessible by the authenticated user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="q"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2>>> ProjectsListForUserAsResponseAsync(
            string username,
            string? q = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}