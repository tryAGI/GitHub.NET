
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: total_request_count
    /// </summary>
    public enum ApiInsightsGetRouteStatsByActorSortItem
    {
        /// <summary>
        ///
        /// </summary>
        ApiRoute,
        /// <summary>
        ///
        /// </summary>
        HttpMethod,
        /// <summary>
        ///
        /// </summary>
        LastRateLimitedTimestamp,
        /// <summary>
        ///
        /// </summary>
        LastRequestTimestamp,
        /// <summary>
        ///
        /// </summary>
        RateLimitedRequestCount,
        /// <summary>
        ///
        /// </summary>
        TotalRequestCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetRouteStatsByActorSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetRouteStatsByActorSortItem value)
        {
            return value switch
            {
                ApiInsightsGetRouteStatsByActorSortItem.ApiRoute => "api_route",
                ApiInsightsGetRouteStatsByActorSortItem.HttpMethod => "http_method",
                ApiInsightsGetRouteStatsByActorSortItem.LastRateLimitedTimestamp => "last_rate_limited_timestamp",
                ApiInsightsGetRouteStatsByActorSortItem.LastRequestTimestamp => "last_request_timestamp",
                ApiInsightsGetRouteStatsByActorSortItem.RateLimitedRequestCount => "rate_limited_request_count",
                ApiInsightsGetRouteStatsByActorSortItem.TotalRequestCount => "total_request_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetRouteStatsByActorSortItem? ToEnum(string value)
        {
            return value switch
            {
                "api_route" => ApiInsightsGetRouteStatsByActorSortItem.ApiRoute,
                "http_method" => ApiInsightsGetRouteStatsByActorSortItem.HttpMethod,
                "last_rate_limited_timestamp" => ApiInsightsGetRouteStatsByActorSortItem.LastRateLimitedTimestamp,
                "last_request_timestamp" => ApiInsightsGetRouteStatsByActorSortItem.LastRequestTimestamp,
                "rate_limited_request_count" => ApiInsightsGetRouteStatsByActorSortItem.RateLimitedRequestCount,
                "total_request_count" => ApiInsightsGetRouteStatsByActorSortItem.TotalRequestCount,
                _ => null,
            };
        }
    }
}