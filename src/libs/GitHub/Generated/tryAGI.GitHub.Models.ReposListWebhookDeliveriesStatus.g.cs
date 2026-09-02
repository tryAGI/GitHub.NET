
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ReposListWebhookDeliveriesStatus
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
    public static class ReposListWebhookDeliveriesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListWebhookDeliveriesStatus value)
        {
            return value switch
            {
                ReposListWebhookDeliveriesStatus.Failure => "failure",
                ReposListWebhookDeliveriesStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListWebhookDeliveriesStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => ReposListWebhookDeliveriesStatus.Failure,
                "success" => ReposListWebhookDeliveriesStatus.Success,
                _ => null,
            };
        }
    }
}