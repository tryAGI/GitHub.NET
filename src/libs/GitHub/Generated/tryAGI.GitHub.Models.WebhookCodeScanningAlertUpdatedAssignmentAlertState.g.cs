
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of a code scanning alert. Events for alerts found outside the default branch will return a `null` value until they are dismissed or fixed.
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAlertState
    {
        /// <summary>
        ///
        /// </summary>
        Dismissed,
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertUpdatedAssignmentAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertUpdatedAssignmentAlertState.Fixed => "fixed",
                WebhookCodeScanningAlertUpdatedAssignmentAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAlertState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertUpdatedAssignmentAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertUpdatedAssignmentAlertState.Fixed,
                "open" => WebhookCodeScanningAlertUpdatedAssignmentAlertState.Open,
                _ => null,
            };
        }
    }
}