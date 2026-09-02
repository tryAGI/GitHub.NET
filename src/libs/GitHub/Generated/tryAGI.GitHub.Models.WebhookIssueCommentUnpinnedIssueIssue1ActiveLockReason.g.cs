
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.Resolved,
                "spam" => WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.Spam,
                "too heated" => WebhookIssueCommentUnpinnedIssueIssue1ActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}