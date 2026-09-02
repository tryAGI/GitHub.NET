
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependabot security updates
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}