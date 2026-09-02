#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get user stats<br/>
        /// Get API usage statistics within an organization for a user broken down by the type of access.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort"></param>
        /// <param name="actorNameSubstring"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsUserStat>> ApiInsightsGetUserStatsAsync(
            string org,
            string userId,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.ApiInsightsGetUserStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsGetUserStatsSortItem>? sort = default,
            string? actorNameSubstring = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user stats<br/>
        /// Get API usage statistics within an organization for a user broken down by the type of access.<br/>
        /// Under normal conditions, you can expect API data to appear within 4–6 hours after making a request. During incidents or periods of unusually high volume, it may take longer to show up.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort"></param>
        /// <param name="actorNameSubstring"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsUserStat>>> ApiInsightsGetUserStatsAsResponseAsync(
            string org,
            string userId,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.ApiInsightsGetUserStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ApiInsightsGetUserStatsSortItem>? sort = default,
            string? actorNameSubstring = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}