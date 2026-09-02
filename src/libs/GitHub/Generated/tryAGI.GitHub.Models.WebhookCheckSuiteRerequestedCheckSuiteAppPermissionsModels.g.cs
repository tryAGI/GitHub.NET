
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsModels.Write,
                _ => null,
            };
        }
    }
}