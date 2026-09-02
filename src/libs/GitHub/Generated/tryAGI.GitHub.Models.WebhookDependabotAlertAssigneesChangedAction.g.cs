
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookDependabotAlertAssigneesChangedAction
    {
        /// <summary>
        ///
        /// </summary>
        AssigneesChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertAssigneesChangedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertAssigneesChangedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertAssigneesChangedAction.AssigneesChanged => "assignees_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertAssigneesChangedAction? ToEnum(string value)
        {
            return value switch
            {
                "assignees_changed" => WebhookDependabotAlertAssigneesChangedAction.AssigneesChanged,
                _ => null,
            };
        }
    }
}