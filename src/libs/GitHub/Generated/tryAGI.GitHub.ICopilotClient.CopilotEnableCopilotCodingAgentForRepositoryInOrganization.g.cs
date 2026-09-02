#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Enable a repository for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Adds a repository to the list of selected repositories enabled for Copilot<br/>
        /// cloud agent in an organization. This method can only be called when the<br/>
        /// cloud agent repository policy is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotEnableCopilotCodingAgentForRepositoryInOrganizationAsync(
            string org,
            int repositoryId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable a repository for Copilot cloud agent in an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Adds a repository to the list of selected repositories enabled for Copilot<br/>
        /// cloud agent in an organization. This method can only be called when the<br/>
        /// cloud agent repository policy is set to `selected`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotEnableCopilotCodingAgentForRepositoryInOrganizationAsResponseAsync(
            string org,
            int repositoryId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}