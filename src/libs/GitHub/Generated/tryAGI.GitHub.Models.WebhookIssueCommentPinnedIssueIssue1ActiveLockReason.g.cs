
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1ActiveLockReason
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
    public static class WebhookIssueCommentPinnedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.Resolved,
                "spam" => WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.Spam,
                "too heated" => WebhookIssueCommentPinnedIssueIssue1ActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}