
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in public preview and is subject to change.
    /// </summary>
    public enum AppPermissionsOrganizationCopilotSeatManagement
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
    public static class AppPermissionsOrganizationCopilotSeatManagementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationCopilotSeatManagement value)
        {
            return value switch
            {
                AppPermissionsOrganizationCopilotSeatManagement.Read => "read",
                AppPermissionsOrganizationCopilotSeatManagement.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationCopilotSeatManagement? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationCopilotSeatManagement.Read,
                "write" => AppPermissionsOrganizationCopilotSeatManagement.Write,
                _ => null,
            };
        }
    }
}