#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing usage summary for a user<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets a summary report of usage for a user.<br/>
        /// **Note:** Only data from the past 24 months is accessible via this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="repository"></param>
        /// <param name="product"></param>
        /// <param name="sku"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.BillingUsageSummaryReportUser> BillingGetGithubBillingUsageSummaryReportUserAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            string? repository = default,
            string? product = default,
            string? sku = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get billing usage summary for a user<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets a summary report of usage for a user.<br/>
        /// **Note:** Only data from the past 24 months is accessible via this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="repository"></param>
        /// <param name="product"></param>
        /// <param name="sku"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.BillingUsageSummaryReportUser>> BillingGetGithubBillingUsageSummaryReportUserAsResponseAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            string? repository = default,
            string? product = default,
            string? sku = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}