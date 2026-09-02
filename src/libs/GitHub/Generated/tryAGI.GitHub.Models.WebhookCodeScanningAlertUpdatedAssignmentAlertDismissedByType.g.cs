
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType
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
    public static class WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.Bot => "Bot",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.Organization => "Organization",
                WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.Bot,
                "Organization" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.Organization,
                "User" => WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedByType.User,
                _ => null,
            };
        }
    }
}