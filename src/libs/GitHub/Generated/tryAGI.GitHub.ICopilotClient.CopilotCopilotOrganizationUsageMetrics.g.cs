#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot organization usage metrics<br/>
        /// Use this endpoint to retrieve download links for the latest 28-day organization Copilot usage metrics report. The report provides comprehensive usage data for Copilot features across the organization.<br/>
        /// The report contains aggregated metrics for the previous 28 days, including usage statistics for various Copilot features, user engagement data, and feature adoption metrics. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date range covered by the report. The report covers a complete 28-day period ending on the most recent day for which data has been processed.<br/>
        /// Organization owners and authorized users with fine-grained "View Organization Copilot Metrics" permission can retrieve Copilot metrics reports for the organization. OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// For more information about organization metrics attribution, see [How are metrics attributed across organizations](https://docs.github.com/copilot/concepts/copilot-metrics#how-are-metrics-attributed-across-organizations).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotUsageMetrics28DayReport> CopilotCopilotOrganizationUsageMetricsAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot organization usage metrics<br/>
        /// Use this endpoint to retrieve download links for the latest 28-day organization Copilot usage metrics report. The report provides comprehensive usage data for Copilot features across the organization.<br/>
        /// The report contains aggregated metrics for the previous 28 days, including usage statistics for various Copilot features, user engagement data, and feature adoption metrics. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date range covered by the report. The report covers a complete 28-day period ending on the most recent day for which data has been processed.<br/>
        /// Organization owners and authorized users with fine-grained "View Organization Copilot Metrics" permission can retrieve Copilot metrics reports for the organization. OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// For more information about organization metrics attribution, see [How are metrics attributed across organizations](https://docs.github.com/copilot/concepts/copilot-metrics#how-are-metrics-attributed-across-organizations).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotUsageMetrics28DayReport>> CopilotCopilotOrganizationUsageMetricsAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}