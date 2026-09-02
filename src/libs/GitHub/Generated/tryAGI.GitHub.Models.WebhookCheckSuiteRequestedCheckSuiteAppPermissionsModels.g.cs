
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels
    {
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels.Write,
                _ => null,
            };
        }
    }
}