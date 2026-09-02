#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get time stats by user<br/>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsByUserAsync(
            string org,
            string userId,
            string minTimestamp,
            string timestampIncrement,
            string? maxTimestamp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get time stats by user<br/>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsTimeStat>>> ApiInsightsGetTimeStatsByUserAsResponseAsync(
            string org,
            string userId,
            string minTimestamp,
            string timestampIncrement,
            string? maxTimestamp = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}