
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of secret scanning non-provider patterns
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}