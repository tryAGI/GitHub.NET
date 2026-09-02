
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequests
    {
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequests value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequests? ToEnum(string value)
        {
            return value switch
            {
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsCopilotRequests.Write,
                _ => null,
            };
        }
    }
}