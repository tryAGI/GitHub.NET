
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of code scanning default setup
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup.NotSet,
                _ => null,
            };
        }
    }
}