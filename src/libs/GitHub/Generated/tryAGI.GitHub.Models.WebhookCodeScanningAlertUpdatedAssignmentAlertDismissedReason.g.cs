
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The reason for dismissing or closing the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason
    {
        /// <summary>
        ///
        /// </summary>
        FalsePositive,
        /// <summary>
        ///
        /// </summary>
        Mitigated,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        UsedInTests,
        /// <summary>
        ///
        /// </summary>
        WontFix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.FalsePositive => "false positive",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.Mitigated => "mitigated",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.UsedInTests => "used in tests",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.WontFix => "won't fix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "false positive" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.FalsePositive,
                "mitigated" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.Mitigated,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "used in tests" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.UsedInTests,
                "won't fix" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason.WontFix,
                _ => null,
            };
        }
    }
}