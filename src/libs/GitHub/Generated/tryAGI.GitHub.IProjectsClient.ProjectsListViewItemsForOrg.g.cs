#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List items for an organization project view<br/>
        /// List items in an organization project with the saved view's filter applied.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="viewNumber"></param>
        /// <param name="fields"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2ItemWithContent>> ProjectsListViewItemsForOrgAsync(
            int projectNumber,
            string org,
            int viewNumber,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? fields = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List items for an organization project view<br/>
        /// List items in an organization project with the saved view's filter applied.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="viewNumber"></param>
        /// <param name="fields"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2ItemWithContent>>> ProjectsListViewItemsForOrgAsResponseAsync(
            int projectNumber,
            string org,
            int viewNumber,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? fields = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}