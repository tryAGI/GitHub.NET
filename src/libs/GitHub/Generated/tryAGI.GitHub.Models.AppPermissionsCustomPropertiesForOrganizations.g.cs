
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token to view and edit custom properties for an organization, when allowed by the property.
    /// </summary>
    public enum AppPermissionsCustomPropertiesForOrganizations
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
    public static class AppPermissionsCustomPropertiesForOrganizationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsCustomPropertiesForOrganizations value)
        {
            return value switch
            {
                AppPermissionsCustomPropertiesForOrganizations.Read => "read",
                AppPermissionsCustomPropertiesForOrganizations.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsCustomPropertiesForOrganizations? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsCustomPropertiesForOrganizations.Read,
                "write" => AppPermissionsCustomPropertiesForOrganizations.Write,
                _ => null,
            };
        }
    }
}