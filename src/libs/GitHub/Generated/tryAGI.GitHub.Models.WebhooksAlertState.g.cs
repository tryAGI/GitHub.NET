
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksAlertState
    {
        /// <summary>
        ///
        /// </summary>
        AutoDismissed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksAlertState value)
        {
            return value switch
            {
                WebhooksAlertState.AutoDismissed => "auto_dismissed",
                WebhooksAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksAlertState? ToEnum(string value)
        {
            return value switch
            {
                "auto_dismissed" => WebhooksAlertState.AutoDismissed,
                "open" => WebhooksAlertState.Open,
                _ => null,
            };
        }
    }
}