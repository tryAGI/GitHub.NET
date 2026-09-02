
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The current push protection setting for this pattern. If this is `not-set`, then it inherits either the enterprise setting if it exists or the default setting.
    /// </summary>
    public enum SecretScanningPatternOverrideSetting
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningPatternOverrideSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningPatternOverrideSetting value)
        {
            return value switch
            {
                SecretScanningPatternOverrideSetting.Disabled => "disabled",
                SecretScanningPatternOverrideSetting.Enabled => "enabled",
                SecretScanningPatternOverrideSetting.NotSet => "not-set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningPatternOverrideSetting? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningPatternOverrideSetting.Disabled,
                "enabled" => SecretScanningPatternOverrideSetting.Enabled,
                "not-set" => SecretScanningPatternOverrideSetting.NotSet,
                _ => null,
            };
        }
    }
}