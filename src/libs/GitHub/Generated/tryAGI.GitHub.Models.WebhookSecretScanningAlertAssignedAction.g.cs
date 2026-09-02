
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookSecretScanningAlertAssignedAction
    {
        /// <summary>
        ///
        /// </summary>
        Assigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertAssignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertAssignedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertAssignedAction.Assigned => "assigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertAssignedAction? ToEnum(string value)
        {
            return value switch
            {
                "assigned" => WebhookSecretScanningAlertAssignedAction.Assigned,
                _ => null,
            };
        }
    }
}