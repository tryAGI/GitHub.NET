#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Remove organizations from the enterprise coding agent policy<br/>
        /// Disables Copilot cloud agent for the specified organizations within the enterprise.<br/>
        /// The enterprise's coding agent policy must be set to `enabled_for_selected_orgs` before<br/>
        /// using this endpoint. Organizations can be specified by login or matched via custom properties.<br/>
        /// Only organizations that have Copilot enabled and belong to the enterprise will be affected.<br/>
        /// Only enterprise owners can remove organizations from the coding agent policy.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyAsync(
            string enterprise,

            global::tryAGI.GitHub.CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove organizations from the enterprise coding agent policy<br/>
        /// Disables Copilot cloud agent for the specified organizations within the enterprise.<br/>
        /// The enterprise's coding agent policy must be set to `enabled_for_selected_orgs` before<br/>
        /// using this endpoint. Organizations can be specified by login or matched via custom properties.<br/>
        /// Only organizations that have Copilot enabled and belong to the enterprise will be affected.<br/>
        /// Only enterprise owners can remove organizations from the coding agent policy.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyAsResponseAsync(
            string enterprise,

            global::tryAGI.GitHub.CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove organizations from the enterprise coding agent policy<br/>
        /// Disables Copilot cloud agent for the specified organizations within the enterprise.<br/>
        /// The enterprise's coding agent policy must be set to `enabled_for_selected_orgs` before<br/>
        /// using this endpoint. Organizations can be specified by login or matched via custom properties.<br/>
        /// Only organizations that have Copilot enabled and belong to the enterprise will be affected.<br/>
        /// Only enterprise owners can remove organizations from the coding agent policy.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="organizations">
        /// List of organization logins within the enterprise to disable Copilot cloud agent for.
        /// </param>
        /// <param name="customProperties">
        /// List of custom property filters to match organizations. Organizations matching any of the specified property name/value pairs will be included. This is a one-time operation, setting the property on an organization in the future will not automatically update its coding agent policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyAsync(
            string enterprise,
            global::System.Collections.Generic.IList<string>? organizations = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie>? customProperties = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}