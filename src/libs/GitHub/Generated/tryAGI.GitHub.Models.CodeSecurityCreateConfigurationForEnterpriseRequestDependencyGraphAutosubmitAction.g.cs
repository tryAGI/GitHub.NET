
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Automatic dependency submission<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.Disabled,
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.Enabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction.NotSet,
                _ => null,
            };
        }
    }
}