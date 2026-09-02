
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookSecretScanningAlertUnassignedAction
    {
        /// <summary>
        ///
        /// </summary>
        Unassigned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertUnassignedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertUnassignedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertUnassignedAction.Unassigned => "unassigned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertUnassignedAction? ToEnum(string value)
        {
            return value switch
            {
                "unassigned" => WebhookSecretScanningAlertUnassignedAction.Unassigned,
                _ => null,
            };
        }
    }
}