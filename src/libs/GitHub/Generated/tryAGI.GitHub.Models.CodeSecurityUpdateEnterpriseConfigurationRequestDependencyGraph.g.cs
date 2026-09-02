
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependency Graph
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}