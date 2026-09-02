#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot organization user-teams report for a specific day<br/>
        /// Use this endpoint to retrieve download links for the Copilot organization user-teams report for a specific day. The report provides user-team join data for Copilot across the organization, with one entry per user-team pair.<br/>
        /// The report contains user-team membership data for the specified day, enabling consumers to join with the existing organization user reports to compute team-level usage metrics. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date of the report. The report covers a complete day for which data has been processed.<br/>
        /// Organization owners and authorized users with fine-grained "View Organization Copilot Metrics" permission can retrieve Copilot metrics reports for the organization. OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// For more information about organization metrics attribution, see [How are metrics attributed across organizations](https://docs.github.com/copilot/concepts/copilot-metrics#how-are-metrics-attributed-across-organizations).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="day">
        /// Example: 2025-10-13
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CopilotUsageMetrics1DayReport> CopilotCopilotOrganizationUserTeamsOneDayReportAsync(
            string org,
            global::System.DateTime day,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Copilot organization user-teams report for a specific day<br/>
        /// Use this endpoint to retrieve download links for the Copilot organization user-teams report for a specific day. The report provides user-team join data for Copilot across the organization, with one entry per user-team pair.<br/>
        /// The report contains user-team membership data for the specified day, enabling consumers to join with the existing organization user reports to compute team-level usage metrics. Reports are generated daily and made available for download through signed URLs with a limited expiration time.<br/>
        /// The response includes download links to the report files, along with the specific date of the report. The report covers a complete day for which data has been processed.<br/>
        /// Organization owners and authorized users with fine-grained "View Organization Copilot Metrics" permission can retrieve Copilot metrics reports for the organization. OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.<br/>
        /// For more information about organization metrics attribution, see [How are metrics attributed across organizations](https://docs.github.com/copilot/concepts/copilot-metrics#how-are-metrics-attributed-across-organizations).
        /// </summary>
        /// <param name="org"></param>
        /// <param name="day">
        /// Example: 2025-10-13
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CopilotUsageMetrics1DayReport>> CopilotCopilotOrganizationUserTeamsOneDayReportAsResponseAsync(
            string org,
            global::System.DateTime day,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}