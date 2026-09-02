
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Automatic dependency submission
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.Disabled,
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.Enabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction.NotSet,
                _ => null,
            };
        }
    }
}