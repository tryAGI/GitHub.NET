
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Dependabot delegated alert dismissal
    /// </summary>
    public enum CodeSecurityConfigurationDependabotDelegatedAlertDismissal
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
    public static class CodeSecurityConfigurationDependabotDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationDependabotDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityConfigurationDependabotDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityConfigurationDependabotDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityConfigurationDependabotDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationDependabotDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityConfigurationDependabotDelegatedAlertDismissal.Disabled,
                "enabled" => CodeSecurityConfigurationDependabotDelegatedAlertDismissal.Enabled,
                "not_set" => CodeSecurityConfigurationDependabotDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}