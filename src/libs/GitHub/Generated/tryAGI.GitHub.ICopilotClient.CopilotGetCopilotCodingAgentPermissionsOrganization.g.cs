#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot cloud agent permissions for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets information about which repositories in an organization have been enabled<br/>
        /// or disabled for the Copilot cloud agent.<br/>
        /// Organization owners can configure whether Copilot cloud agent is enabled for<br/>
        /// all repositories, selected repositories, or no repositories owned by organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotGetCopilotCodingAgentPermissionsOrganizationResponse> CopilotGetCopilotCodingAgentPermissionsOrganizationAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot cloud agent permissions for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets information about which repositories in an organization have been enabled<br/>
        /// or disabled for the Copilot cloud agent.<br/>
        /// Organization owners can configure whether Copilot cloud agent is enabled for<br/>
        /// all repositories, selected repositories, or no repositories owned by organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotGetCopilotCodingAgentPermissionsOrganizationResponse>> CopilotGetCopilotCodingAgentPermissionsOrganizationAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}