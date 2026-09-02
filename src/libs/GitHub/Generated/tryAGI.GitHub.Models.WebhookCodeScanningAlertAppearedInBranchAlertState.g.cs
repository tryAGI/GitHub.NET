
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of a code scanning alert. Events for alerts found outside the default branch will return a `null` value until they are dismissed or fixed.
    /// </summary>
    public enum WebhookCodeScanningAlertAppearedInBranchAlertState
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
    public static class WebhookCodeScanningAlertAppearedInBranchAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertAppearedInBranchAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertAppearedInBranchAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertAppearedInBranchAlertState.Fixed => "fixed",
                WebhookCodeScanningAlertAppearedInBranchAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertAppearedInBranchAlertState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookCodeScanningAlertAppearedInBranchAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertAppearedInBranchAlertState.Fixed,
                "open" => WebhookCodeScanningAlertAppearedInBranchAlertState.Open,
                _ => null,
            };
        }
    }
}