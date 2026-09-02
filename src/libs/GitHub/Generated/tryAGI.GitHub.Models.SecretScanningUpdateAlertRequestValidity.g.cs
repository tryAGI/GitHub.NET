
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Sets the validity of the secret scanning alert. Can be `active`, `inactive`, or `null` to clear the override.
    /// </summary>
    public enum SecretScanningUpdateAlertRequestValidity
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningUpdateAlertRequestValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateAlertRequestValidity value)
        {
            return value switch
            {
                SecretScanningUpdateAlertRequestValidity.Active => "active",
                SecretScanningUpdateAlertRequestValidity.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateAlertRequestValidity? ToEnum(string value)
        {
            return value switch
            {
                "active" => SecretScanningUpdateAlertRequestValidity.Active,
                "inactive" => SecretScanningUpdateAlertRequestValidity.Inactive,
                _ => null,
            };
        }
    }
}