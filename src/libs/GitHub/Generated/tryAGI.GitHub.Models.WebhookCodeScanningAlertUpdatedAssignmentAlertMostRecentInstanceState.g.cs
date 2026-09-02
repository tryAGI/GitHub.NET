
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState
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
    public static class WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Dismissed => "dismissed",
                WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Fixed => "fixed",
                WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Dismissed,
                "fixed" => WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Fixed,
                "open" => WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceState.Open,
                _ => null,
            };
        }
    }
}