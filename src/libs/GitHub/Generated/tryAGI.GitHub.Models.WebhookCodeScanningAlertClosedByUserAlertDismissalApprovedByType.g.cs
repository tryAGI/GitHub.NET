
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType value)
        {
            return value switch
            {
                WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.Bot => "Bot",
                WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.Organization => "Organization",
                WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.Bot,
                "Organization" => WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.Organization,
                "User" => WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedByType.User,
                _ => null,
            };
        }
    }
}