
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Note,
        /// <summary>
        ///
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Error => "error",
                WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.None => "none",
                WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Note => "note",
                WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Error,
                "none" => WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.None,
                "note" => WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Note,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "warning" => WebhookCodeScanningAlertUpdatedAssignmentAlertRuleSeverity.Warning,
                _ => null,
            };
        }
    }
}