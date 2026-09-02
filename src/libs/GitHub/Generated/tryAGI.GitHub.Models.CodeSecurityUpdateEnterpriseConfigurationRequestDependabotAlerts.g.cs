
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependabot alerts
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}