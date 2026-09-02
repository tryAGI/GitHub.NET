
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal
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
    public static class CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}