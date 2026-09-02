
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Push protection setting to set for the pattern.
    /// </summary>
    public enum SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting
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
    public static class SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting value)
        {
            return value switch
            {
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Disabled => "disabled",
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Enabled => "enabled",
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.NotSet => "not-set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Disabled,
                "enabled" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Enabled,
                "not-set" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.NotSet,
                _ => null,
            };
        }
    }
}