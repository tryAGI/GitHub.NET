#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot users usage metrics<br/>
        /// Use this endpoint to retrieve download links for the latest 28-day enterprise users Copilot usage metrics report. The report provides detailed user-level usage data and engagement metrics for Copilot features across the enterprise.<br/>
        /// The report contains user-specific metrics for the previous 28 days, including individual user engagement statistics, feature usage patterns, and adoption metrics broken down by user. This report allows authorized users to analyze Copilot usage at the user level to understand adoption patterns and identify opportunities for increased engagement.<br/>
        /// Reports are generated daily and made available for download through signed URLs with a limited expiration time. The response includes download links to the report files, along with the specific date range covered by the report. The report covers a complete 28-day period ending on the most recent day for which data has been processed.<br/>
        /// Enterprise owners, billing managers, and authorized users with fine-grained "View Enterprise Copilot Metrics" permission can retrieve Copilot metrics reports for the enterprise. OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotUsageMetrics28DayReport> CopilotCopilotUsersUsageMetricsAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot users usage metrics<br/>
        /// Use this endpoint to retrieve download links for the latest 28-day enterprise users Copilot usage metrics report. The report provides detailed user-level usage data and engagement metrics for Copilot features across the enterprise.<br/>
        /// The report contains user-specific metrics for the previous 28 days, including individual user engagement statistics, feature usage patterns, and adoption metrics broken down by user. This report allows authorized users to analyze Copilot usage at the user level to understand adoption patterns and identify opportunities for increased engagement.<br/>
        /// Reports are generated daily and made available for download through signed URLs with a limited expiration time. The response includes download links to the report files, along with the specific date range covered by the report. The report covers a complete 28-day period ending on the most recent day for which data has been processed.<br/>
        /// Enterprise owners, billing managers, and authorized users with fine-grained "View Enterprise Copilot Metrics" permission can retrieve Copilot metrics reports for the enterprise. OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotUsageMetrics28DayReport>> CopilotCopilotUsersUsageMetricsAsResponseAsync(
            string enterprise,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}