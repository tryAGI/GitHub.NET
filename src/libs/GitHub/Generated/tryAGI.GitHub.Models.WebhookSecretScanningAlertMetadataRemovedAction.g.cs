
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookSecretScanningAlertMetadataRemovedAction
    {
        /// <summary>
        ///
        /// </summary>
        MetadataRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertMetadataRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertMetadataRemovedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertMetadataRemovedAction.MetadataRemoved => "metadata_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertMetadataRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "metadata_removed" => WebhookSecretScanningAlertMetadataRemovedAction.MetadataRemoved,
                _ => null,
            };
        }
    }
}