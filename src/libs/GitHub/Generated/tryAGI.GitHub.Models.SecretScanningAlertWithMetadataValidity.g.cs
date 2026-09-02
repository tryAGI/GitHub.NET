
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The token status as of the latest validity check.
    /// </summary>
    public enum SecretScanningAlertWithMetadataValidity
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Inactive,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertWithMetadataValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertWithMetadataValidity value)
        {
            return value switch
            {
                SecretScanningAlertWithMetadataValidity.Active => "active",
                SecretScanningAlertWithMetadataValidity.Inactive => "inactive",
                SecretScanningAlertWithMetadataValidity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertWithMetadataValidity? ToEnum(string value)
        {
            return value switch
            {
                "active" => SecretScanningAlertWithMetadataValidity.Active,
                "inactive" => SecretScanningAlertWithMetadataValidity.Inactive,
                "unknown" => SecretScanningAlertWithMetadataValidity.Unknown,
                _ => null,
            };
        }
    }
}