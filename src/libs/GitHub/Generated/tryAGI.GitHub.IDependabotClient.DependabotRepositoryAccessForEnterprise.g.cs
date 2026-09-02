#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Lists the repositories Dependabot can access in an enterprise<br/>
        /// Lists repositories that enterprise admins have allowed Dependabot to access when updating dependencies across organizations in the enterprise.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.DependabotRepositoryAccessDetails> DependabotRepositoryAccessForEnterpriseAsync(
            string enterprise,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists the repositories Dependabot can access in an enterprise<br/>
        /// Lists repositories that enterprise admins have allowed Dependabot to access when updating dependencies across organizations in the enterprise.<br/>
        /// The authenticated user must be an enterprise owner to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.DependabotRepositoryAccessDetails>> DependabotRepositoryAccessForEnterpriseAsResponseAsync(
            string enterprise,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps DependabotRepositoryAccessForEnterpriseAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.NullableSimpleRepository&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.NullableSimpleRepository> DependabotRepositoryAccessForEnterpriseAutoPagingAsync(
            string enterprise,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}