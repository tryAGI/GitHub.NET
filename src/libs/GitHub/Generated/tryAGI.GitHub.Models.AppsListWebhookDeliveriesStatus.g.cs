
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsListWebhookDeliveriesStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsListWebhookDeliveriesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsListWebhookDeliveriesStatus value)
        {
            return value switch
            {
                AppsListWebhookDeliveriesStatus.Failure => "failure",
                AppsListWebhookDeliveriesStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsListWebhookDeliveriesStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => AppsListWebhookDeliveriesStatus.Failure,
                "success" => AppsListWebhookDeliveriesStatus.Success,
                _ => null,
            };
        }
    }
}