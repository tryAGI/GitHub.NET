#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Set selected repositories for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Replaces the list of selected repositories that are enabled for Copilot cloud<br/>
        /// agent in an organization. This method can only be called when the cloud agent<br/>
        /// repository policy is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSetCopilotCodingAgentSelectedRepositoriesForOrganizationAsync(
            string org,

            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentSelectedRepositoriesForOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set selected repositories for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Replaces the list of selected repositories that are enabled for Copilot cloud<br/>
        /// agent in an organization. This method can only be called when the cloud agent<br/>
        /// repository policy is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSetCopilotCodingAgentSelectedRepositoriesForOrganizationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentSelectedRepositoriesForOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set selected repositories for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Replaces the list of selected repositories that are enabled for Copilot cloud<br/>
        /// agent in an organization. This method can only be called when the cloud agent<br/>
        /// repository policy is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs to enable for Copilot cloud agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CopilotSetCopilotCodingAgentSelectedRepositoriesForOrganizationAsync(
            string org,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}