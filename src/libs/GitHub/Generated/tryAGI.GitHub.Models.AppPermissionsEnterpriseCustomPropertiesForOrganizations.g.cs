
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token for organization custom properties management at the enterprise level.
    /// </summary>
    public enum AppPermissionsEnterpriseCustomPropertiesForOrganizations
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
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
    public static class AppPermissionsEnterpriseCustomPropertiesForOrganizationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsEnterpriseCustomPropertiesForOrganizations value)
        {
            return value switch
            {
                AppPermissionsEnterpriseCustomPropertiesForOrganizations.Admin => "admin",
                AppPermissionsEnterpriseCustomPropertiesForOrganizations.Read => "read",
                AppPermissionsEnterpriseCustomPropertiesForOrganizations.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsEnterpriseCustomPropertiesForOrganizations? ToEnum(string value)
        {
            return value switch
            {
                "admin" => AppPermissionsEnterpriseCustomPropertiesForOrganizations.Admin,
                "read" => AppPermissionsEnterpriseCustomPropertiesForOrganizations.Read,
                "write" => AppPermissionsEnterpriseCustomPropertiesForOrganizations.Write,
                _ => null,
            };
        }
    }
}