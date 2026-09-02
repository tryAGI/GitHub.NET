#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get an item for an organization owned project<br/>
        /// Get a specific item from an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="itemId"></param>
        /// <param name="fields"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ProjectsV2ItemWithContent> ProjectsGetOrgItemAsync(
            int projectNumber,
            string org,
            int itemId,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? fields = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an item for an organization owned project<br/>
        /// Get a specific item from an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="itemId"></param>
        /// <param name="fields"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ProjectsV2ItemWithContent>> ProjectsGetOrgItemAsResponseAsync(
            int projectNumber,
            string org,
            int itemId,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? fields = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}