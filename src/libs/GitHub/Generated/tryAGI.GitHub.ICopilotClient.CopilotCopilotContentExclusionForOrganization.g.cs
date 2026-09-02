#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot content exclusion rules for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets information about an organization's Copilot content exclusion path rules.<br/>
        /// To configure these settings, go to the organization's settings on GitHub.<br/>
        /// For more information, see "[Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot#configuring-content-exclusions-for-your-organization)."<br/>
        /// Organization owners can view details about Copilot content exclusion rules for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `copilot` or `read:org` scopes to use this endpoint.<br/>
        /// &gt; [!CAUTION]<br/>
        /// &gt; * At this time, the API does not support comments. This endpoint will not return any comments in the existing rules.<br/>
        /// &gt; * At this time, the API does not support duplicate keys. If your content exclusion configuration contains duplicate keys, the API will return only the last occurrence of that key. For example, if duplicate entries are present, only the final value will be included in the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> CopilotCopilotContentExclusionForOrganizationAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot content exclusion rules for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets information about an organization's Copilot content exclusion path rules.<br/>
        /// To configure these settings, go to the organization's settings on GitHub.<br/>
        /// For more information, see "[Excluding content from GitHub Copilot](https://docs.github.com/copilot/managing-copilot/configuring-and-auditing-content-exclusion/excluding-content-from-github-copilot#configuring-content-exclusions-for-your-organization)."<br/>
        /// Organization owners can view details about Copilot content exclusion rules for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `copilot` or `read:org` scopes to use this endpoint.<br/>
        /// &gt; [!CAUTION]<br/>
        /// &gt; * At this time, the API does not support comments. This endpoint will not return any comments in the existing rules.<br/>
        /// &gt; * At this time, the API does not support duplicate keys. If your content exclusion configuration contains duplicate keys, the API will return only the last occurrence of that key. For example, if duplicate entries are present, only the final value will be included in the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>> CopilotCopilotContentExclusionForOrganizationAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}