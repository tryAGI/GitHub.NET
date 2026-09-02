#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Set Copilot content exclusion rules for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets Copilot content exclusion path rules for an organization.<br/>
        /// To configure these settings, go to the organization's settings on GitHub.<br/>
        /// For more information, see "[Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot#configuring-content-exclusions-for-your-organization)."<br/>
        /// Organization owners can set Copilot content exclusion rules for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `copilot` scope to use this endpoint.<br/>
        /// &gt; [!CAUTION]<br/>
        /// &gt; * At this time, the API does not support comments. When using this endpoint, any existing comments in your rules will be deleted.<br/>
        /// &gt; * At this time, the API does not support duplicate keys. If you submit content exclusions through the API with duplicate keys, only the last occurrence will be saved. Earlier entries with the same key will be overwritten.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationResponse> CopilotSetCopilotContentExclusionForOrganizationAsync(
            string org,

            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.AnyOf<string, global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant2, global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3>>> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Copilot content exclusion rules for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets Copilot content exclusion path rules for an organization.<br/>
        /// To configure these settings, go to the organization's settings on GitHub.<br/>
        /// For more information, see "[Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot#configuring-content-exclusions-for-your-organization)."<br/>
        /// Organization owners can set Copilot content exclusion rules for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `copilot` scope to use this endpoint.<br/>
        /// &gt; [!CAUTION]<br/>
        /// &gt; * At this time, the API does not support comments. When using this endpoint, any existing comments in your rules will be deleted.<br/>
        /// &gt; * At this time, the API does not support duplicate keys. If you submit content exclusions through the API with duplicate keys, only the last occurrence will be saved. Earlier entries with the same key will be overwritten.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationResponse>> CopilotSetCopilotContentExclusionForOrganizationAsResponseAsync(
            string org,

            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.AnyOf<string, global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant2, global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationRequestItemVariant3>>> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Copilot content exclusion rules for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets Copilot content exclusion path rules for an organization.<br/>
        /// To configure these settings, go to the organization's settings on GitHub.<br/>
        /// For more information, see "[Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot#configuring-content-exclusions-for-your-organization)."<br/>
        /// Organization owners can set Copilot content exclusion rules for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `copilot` scope to use this endpoint.<br/>
        /// &gt; [!CAUTION]<br/>
        /// &gt; * At this time, the API does not support comments. When using this endpoint, any existing comments in your rules will be deleted.<br/>
        /// &gt; * At this time, the API does not support duplicate keys. If you submit content exclusions through the API with duplicate keys, only the last occurrence will be saved. Earlier entries with the same key will be overwritten.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotSetCopilotContentExclusionForOrganizationResponse> CopilotSetCopilotContentExclusionForOrganizationAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}