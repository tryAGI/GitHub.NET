
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAttestations.Write,
                _ => null,
            };
        }
    }
}