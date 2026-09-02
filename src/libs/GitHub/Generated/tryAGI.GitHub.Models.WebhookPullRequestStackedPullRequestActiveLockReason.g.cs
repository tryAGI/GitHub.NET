
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestActiveLockReason
    {
        /// <summary>
        ///
        /// </summary>
        OffTopic,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        Resolved,
        /// <summary>
        ///
        /// </summary>
        Spam,
        /// <summary>
        ///
        /// </summary>
        TooHeated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestStackedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookPullRequestStackedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestStackedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestStackedPullRequestActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookPullRequestStackedPullRequestActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestStackedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookPullRequestStackedPullRequestActiveLockReason.Resolved,
                "spam" => WebhookPullRequestStackedPullRequestActiveLockReason.Spam,
                "too heated" => WebhookPullRequestStackedPullRequestActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}