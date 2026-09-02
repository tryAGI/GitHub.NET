
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations.Write,
                _ => null,
            };
        }
    }
}