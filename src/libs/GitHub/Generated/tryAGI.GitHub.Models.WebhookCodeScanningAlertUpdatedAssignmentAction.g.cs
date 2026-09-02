
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCodeScanningAlertUpdatedAssignmentAction
    {
        /// <summary>
        ///
        /// </summary>
        UpdatedAssignment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertUpdatedAssignmentActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertUpdatedAssignmentAction value)
        {
            return value switch
            {
                WebhookCodeScanningAlertUpdatedAssignmentAction.UpdatedAssignment => "updated_assignment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertUpdatedAssignmentAction? ToEnum(string value)
        {
            return value switch
            {
                "updated_assignment" => WebhookCodeScanningAlertUpdatedAssignmentAction.UpdatedAssignment,
                _ => null,
            };
        }
    }
}