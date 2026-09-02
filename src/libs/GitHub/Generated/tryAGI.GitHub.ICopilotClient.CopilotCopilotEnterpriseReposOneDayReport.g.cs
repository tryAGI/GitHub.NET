#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot enterprise repository report for a specific day<br/>
        /// Use this endpoint to retrieve download links for the Copilot enterprise repository report for a specific day. The report provides per-repository pull request metrics for Copilot across the enterprise, with one entry per repository.<br/>
        /// The report contains repository-level pull request activity for the specified day, including the Copilot Coding Agent (CCA) and Copilot Code Review (CCR) breakdowns. Only repositories that had activity on the specified day are included. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date of the report. The report covers a complete day for which data has been processed.<br/>
        /// Enterprise owners, billing managers, and authorized users with fine-grained "View Enterprise Copilot Metrics" permission can retrieve Copilot metrics reports for the enterprise. OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="day">
        /// Example: 2025-10-13
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotUsageMetrics1DayReport> CopilotCopilotEnterpriseReposOneDayReportAsync(
            string enterprise,
            global::System.DateTime day,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot enterprise repository report for a specific day<br/>
        /// Use this endpoint to retrieve download links for the Copilot enterprise repository report for a specific day. The report provides per-repository pull request metrics for Copilot across the enterprise, with one entry per repository.<br/>
        /// The report contains repository-level pull request activity for the specified day, including the Copilot Coding Agent (CCA) and Copilot Code Review (CCR) breakdowns. Only repositories that had activity on the specified day are included. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date of the report. The report covers a complete day for which data has been processed.<br/>
        /// Enterprise owners, billing managers, and authorized users with fine-grained "View Enterprise Copilot Metrics" permission can retrieve Copilot metrics reports for the enterprise. OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="day">
        /// Example: 2025-10-13
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotUsageMetrics1DayReport>> CopilotCopilotEnterpriseReposOneDayReportAsResponseAsync(
            string enterprise,
            global::System.DateTime day,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}