#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List repository organization secrets<br/>
        /// Lists all organization secrets shared with a repository without revealing their encrypted<br/>
        /// values.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AgentsListRepoOrganizationSecretsResponse> AgentsListRepoOrganizationSecretsAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repository organization secrets<br/>
        /// Lists all organization secrets shared with a repository without revealing their encrypted<br/>
        /// values.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AgentsListRepoOrganizationSecretsResponse>> AgentsListRepoOrganizationSecretsAsResponseAsync(
            string owner,
            string repo,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AgentsListRepoOrganizationSecretsAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.ActionsSecret&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.ActionsSecret> AgentsListRepoOrganizationSecretsAutoPagingAsync(
            string owner,
            string repo,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}