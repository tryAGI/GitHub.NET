
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookSecretScanningAlertMetadataCreatedAction
    {
        /// <summary>
        ///
        /// </summary>
        MetadataCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertMetadataCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertMetadataCreatedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertMetadataCreatedAction.MetadataCreated => "metadata_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertMetadataCreatedAction? ToEnum(string value)
        {
            return value switch
            {
                "metadata_created" => WebhookSecretScanningAlertMetadataCreatedAction.MetadataCreated,
                _ => null,
            };
        }
    }
}