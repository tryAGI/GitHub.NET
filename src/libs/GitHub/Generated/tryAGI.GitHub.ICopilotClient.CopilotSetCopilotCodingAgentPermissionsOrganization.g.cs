#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Set Copilot cloud agent permissions for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets the policy for which repositories in an organization can use Copilot cloud agent.<br/>
        /// Organization owners can configure whether Copilot cloud agent is enabled for<br/>
        /// all repositories, selected repositories, or no repositories owned by the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSetCopilotCodingAgentPermissionsOrganizationAsync(
            string org,

            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentPermissionsOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Copilot cloud agent permissions for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets the policy for which repositories in an organization can use Copilot cloud agent.<br/>
        /// Organization owners can configure whether Copilot cloud agent is enabled for<br/>
        /// all repositories, selected repositories, or no repositories owned by the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSetCopilotCodingAgentPermissionsOrganizationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentPermissionsOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Copilot cloud agent permissions for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets the policy for which repositories in an organization can use Copilot cloud agent.<br/>
        /// Organization owners can configure whether Copilot cloud agent is enabled for<br/>
        /// all repositories, selected repositories, or no repositories owned by the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories">
        /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CopilotSetCopilotCodingAgentPermissionsOrganizationAsync(
            string org,
            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories enabledRepositories,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}