
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependency Graph<br/>
    /// Default Value: enabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph.NotSet,
                _ => null,
            };
        }
    }
}