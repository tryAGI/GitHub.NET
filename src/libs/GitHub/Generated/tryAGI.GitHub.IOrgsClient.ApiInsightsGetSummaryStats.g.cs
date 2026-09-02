#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get summary stats<br/>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsAsync(
            string org,
            string minTimestamp,
            string? maxTimestamp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get summary stats<br/>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ApiInsightsSummaryStats>> ApiInsightsGetSummaryStatsAsResponseAsync(
            string org,
            string minTimestamp,
            string? maxTimestamp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}