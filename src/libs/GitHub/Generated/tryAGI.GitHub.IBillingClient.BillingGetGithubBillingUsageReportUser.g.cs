#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing usage report for a user<br/>
        /// Gets a report of the total usage for a user.<br/>
        /// **Note:** This endpoint is only available to users with access to the enhanced billing platform.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.BillingUsageReportUser> BillingGetGithubBillingUsageReportUserAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get billing usage report for a user<br/>
        /// Gets a report of the total usage for a user.<br/>
        /// **Note:** This endpoint is only available to users with access to the enhanced billing platform.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.BillingUsageReportUser>> BillingGetGithubBillingUsageReportUserAsResponseAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}