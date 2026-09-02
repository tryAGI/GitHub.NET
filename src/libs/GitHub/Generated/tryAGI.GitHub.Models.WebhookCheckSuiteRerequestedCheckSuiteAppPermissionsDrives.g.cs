
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrivesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDrives.Write,
                _ => null,
            };
        }
    }
}