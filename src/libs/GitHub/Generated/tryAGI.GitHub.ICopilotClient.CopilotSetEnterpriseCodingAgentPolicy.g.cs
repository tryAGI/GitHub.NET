#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Set the coding agent policy for an enterprise<br/>
        /// Sets the policy for Copilot cloud agent usage across an enterprise.<br/>
        /// Enterprise owners can configure whether Copilot cloud agent is enabled for all<br/>
        /// organizations, disabled for all organizations, configured by individual organization<br/>
        /// admins, or enabled for selected organizations only.<br/>
        /// Only enterprise owners can set the coding agent policy for their enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotSetEnterpriseCodingAgentPolicyAsync(
            string enterprise,

            global::tryAGI.GitHub.CopilotSetEnterpriseCodingAgentPolicyRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the coding agent policy for an enterprise<br/>
        /// Sets the policy for Copilot cloud agent usage across an enterprise.<br/>
        /// Enterprise owners can configure whether Copilot cloud agent is enabled for all<br/>
        /// organizations, disabled for all organizations, configured by individual organization<br/>
        /// admins, or enabled for selected organizations only.<br/>
        /// Only enterprise owners can set the coding agent policy for their enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotSetEnterpriseCodingAgentPolicyAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.CopilotSetEnterpriseCodingAgentPolicyRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the coding agent policy for an enterprise<br/>
        /// Sets the policy for Copilot cloud agent usage across an enterprise.<br/>
        /// Enterprise owners can configure whether Copilot cloud agent is enabled for all<br/>
        /// organizations, disabled for all organizations, configured by individual organization<br/>
        /// admins, or enabled for selected organizations only.<br/>
        /// Only enterprise owners can set the coding agent policy for their enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="policyState">
        /// The policy state for Copilot cloud agent in the enterprise. Can be one of `enabled_for_all_orgs`, `disabled_for_all_orgs`, `enabled_for_selected_orgs`, or `configured_by_org_admins`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CopilotSetEnterpriseCodingAgentPolicyAsync(
            string enterprise,
            global::tryAGI.GitHub.CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState policyState,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}