
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecretScanningListOrgCustomPatternsPushProtection
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListOrgCustomPatternsPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListOrgCustomPatternsPushProtection value)
        {
            return value switch
            {
                SecretScanningListOrgCustomPatternsPushProtection.Disabled => "disabled",
                SecretScanningListOrgCustomPatternsPushProtection.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListOrgCustomPatternsPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningListOrgCustomPatternsPushProtection.Disabled,
                "enabled" => SecretScanningListOrgCustomPatternsPushProtection.Enabled,
                _ => null,
            };
        }
    }
}