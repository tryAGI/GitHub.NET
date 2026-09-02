
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The category of the detected secret. `default` covers specific provider patterns and custom patterns; `generic` covers non-specific patterns and AI-detected secrets.
    /// </summary>
    public enum SecretScanningAlertWebhookSecretCategory
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Generic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertWebhookSecretCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertWebhookSecretCategory value)
        {
            return value switch
            {
                SecretScanningAlertWebhookSecretCategory.Default => "default",
                SecretScanningAlertWebhookSecretCategory.Generic => "generic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertWebhookSecretCategory? ToEnum(string value)
        {
            return value switch
            {
                "default" => SecretScanningAlertWebhookSecretCategory.Default,
                "generic" => SecretScanningAlertWebhookSecretCategory.Generic,
                _ => null,
            };
        }
    }
}