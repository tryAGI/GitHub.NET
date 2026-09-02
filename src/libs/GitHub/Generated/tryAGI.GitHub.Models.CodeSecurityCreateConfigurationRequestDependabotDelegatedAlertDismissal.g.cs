
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal
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
    public static class CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}