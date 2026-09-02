#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot cloud agent configuration for a repository<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets the Copilot cloud agent configuration for a repository, including MCP server<br/>
        /// configuration, enabled review tools, Actions workflow approval settings, and firewall<br/>
        /// configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotGetCopilotCloudAgentConfigurationResponse> CopilotGetCopilotCloudAgentConfigurationAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot cloud agent configuration for a repository<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets the Copilot cloud agent configuration for a repository, including MCP server<br/>
        /// configuration, enabled review tools, Actions workflow approval settings, and firewall<br/>
        /// configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotGetCopilotCloudAgentConfigurationResponse>> CopilotGetCopilotCloudAgentConfigurationAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}