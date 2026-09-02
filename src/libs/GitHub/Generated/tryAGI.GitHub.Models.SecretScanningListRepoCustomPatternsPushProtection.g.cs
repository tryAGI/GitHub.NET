
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecretScanningListRepoCustomPatternsPushProtection
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
    public static class SecretScanningListRepoCustomPatternsPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListRepoCustomPatternsPushProtection value)
        {
            return value switch
            {
                SecretScanningListRepoCustomPatternsPushProtection.Disabled => "disabled",
                SecretScanningListRepoCustomPatternsPushProtection.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListRepoCustomPatternsPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningListRepoCustomPatternsPushProtection.Disabled,
                "enabled" => SecretScanningListRepoCustomPatternsPushProtection.Enabled,
                _ => null,
            };
        }
    }
}