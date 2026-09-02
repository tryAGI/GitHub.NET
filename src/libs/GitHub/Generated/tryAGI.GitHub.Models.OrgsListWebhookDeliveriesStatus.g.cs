
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum OrgsListWebhookDeliveriesStatus
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
    public static class OrgsListWebhookDeliveriesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListWebhookDeliveriesStatus value)
        {
            return value switch
            {
                OrgsListWebhookDeliveriesStatus.Failure => "failure",
                OrgsListWebhookDeliveriesStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListWebhookDeliveriesStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => OrgsListWebhookDeliveriesStatus.Failure,
                "success" => OrgsListWebhookDeliveriesStatus.Success,
                _ => null,
            };
        }
    }
}