#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// List repositories enabled for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Lists the selected repositories that are enabled for Copilot cloud agent in an organization.<br/>
        /// Organization owners can use this endpoint when the coding agent repository policy<br/>
        /// is set to `selected` to see which repositories have been enabled.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationResponse> CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories enabled for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Lists the selected repositories that are enabled for Copilot cloud agent in an organization.<br/>
        /// Organization owners can use this endpoint when the coding agent repository policy<br/>
        /// is set to `selected` to see which repositories have been enabled.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationResponse>> CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationAsResponseAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.MinimalRepository&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.MinimalRepository> CopilotListCopilotCodingAgentSelectedRepositoriesForOrganizationAutoPagingAsync(
            string org,             int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}