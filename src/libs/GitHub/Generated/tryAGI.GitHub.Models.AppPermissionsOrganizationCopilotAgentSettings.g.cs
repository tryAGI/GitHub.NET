
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage Copilot cloud agent settings for an organization.
    /// </summary>
    public enum AppPermissionsOrganizationCopilotAgentSettings
    {
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsOrganizationCopilotAgentSettingsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCopilotAgentSettings value)
        {
            return value switch
            {
                AppPermissionsOrganizationCopilotAgentSettings.Read => "read",
                AppPermissionsOrganizationCopilotAgentSettings.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCopilotAgentSettings? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationCopilotAgentSettings.Read,
                "write" => AppPermissionsOrganizationCopilotAgentSettings.Write,
                _ => null,
            };
        }
    }
}