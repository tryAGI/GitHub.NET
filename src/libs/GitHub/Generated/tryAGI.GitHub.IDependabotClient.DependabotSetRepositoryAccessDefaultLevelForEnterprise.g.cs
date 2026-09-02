#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Set the default repository access level for Dependabot in an enterprise<br/>
        /// Sets the default level of repository access Dependabot will have while performing an update across organizations in the enterprise. Available values are:<br/>
        /// - 'public' - Dependabot will only have access to public repositories, unless access is explicitly granted to non-public repositories.<br/>
        /// - 'internal' - Dependabot will only have access to public and internal repositories, unless access is explicitly granted to private repositories.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task DependabotSetRepositoryAccessDefaultLevelForEnterpriseAsync(
            string enterprise,

            global::tryAGI.GitHub.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the default repository access level for Dependabot in an enterprise<br/>
        /// Sets the default level of repository access Dependabot will have while performing an update across organizations in the enterprise. Available values are:<br/>
        /// - 'public' - Dependabot will only have access to public repositories, unless access is explicitly granted to non-public repositories.<br/>
        /// - 'internal' - Dependabot will only have access to public and internal repositories, unless access is explicitly granted to private repositories.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> DependabotSetRepositoryAccessDefaultLevelForEnterpriseAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the default repository access level for Dependabot in an enterprise<br/>
        /// Sets the default level of repository access Dependabot will have while performing an update across organizations in the enterprise. Available values are:<br/>
        /// - 'public' - Dependabot will only have access to public repositories, unless access is explicitly granted to non-public repositories.<br/>
        /// - 'internal' - Dependabot will only have access to public and internal repositories, unless access is explicitly granted to private repositories.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="defaultLevel">
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DependabotSetRepositoryAccessDefaultLevelForEnterpriseAsync(
            string enterprise,
            global::tryAGI.GitHub.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel defaultLevel,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}