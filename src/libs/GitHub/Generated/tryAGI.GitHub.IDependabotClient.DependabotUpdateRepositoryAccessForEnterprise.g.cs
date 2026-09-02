#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Updates Dependabot's repository access list for an enterprise<br/>
        /// Updates repositories according to the list of repositories that enterprise admins have given Dependabot access to when they've updated dependencies across organizations in the enterprise.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.<br/>
        /// **Example request body:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "repository_ids_to_add": [123, 456],<br/>
        ///   "repository_ids_to_remove": [789]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.DependabotUpdateRepositoryAccessForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates Dependabot's repository access list for an enterprise<br/>
        /// Updates repositories according to the list of repositories that enterprise admins have given Dependabot access to when they've updated dependencies across organizations in the enterprise.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.<br/>
        /// **Example request body:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "repository_ids_to_add": [123, 456],<br/>
        ///   "repository_ids_to_remove": [789]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> DependabotUpdateRepositoryAccessForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.DependabotUpdateRepositoryAccessForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates Dependabot's repository access list for an enterprise<br/>
        /// Updates repositories according to the list of repositories that enterprise admins have given Dependabot access to when they've updated dependencies across organizations in the enterprise.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.<br/>
        /// **Example request body:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "repository_ids_to_add": [123, 456],<br/>
        ///   "repository_ids_to_remove": [789]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="repositoryIdsToAdd">
        /// List of repository IDs to add.
        /// </param>
        /// <param name="repositoryIdsToRemove">
        /// List of repository IDs to remove.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForEnterpriseAsync(
            string enterprise,
            global::System.Collections.Generic.IList<int>? repositoryIdsToAdd = default,
            global::System.Collections.Generic.IList<int>? repositoryIdsToRemove = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}