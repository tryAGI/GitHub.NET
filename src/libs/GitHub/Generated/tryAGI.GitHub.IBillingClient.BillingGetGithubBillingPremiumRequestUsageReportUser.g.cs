#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing premium request usage report for a user<br/>
        /// Gets a report of premium request usage for a user.<br/>
        /// **Note:** Only data from the past 24 months is accessible via this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="model"></param>
        /// <param name="product"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.BillingPremiumRequestUsageReportUser> BillingGetGithubBillingPremiumRequestUsageReportUserAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            string? model = default,
            string? product = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get billing premium request usage report for a user<br/>
        /// Gets a report of premium request usage for a user.<br/>
        /// **Note:** Only data from the past 24 months is accessible via this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="model"></param>
        /// <param name="product"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.BillingPremiumRequestUsageReportUser>> BillingGetGithubBillingPremiumRequestUsageReportUserAsResponseAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            string? model = default,
            string? product = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}