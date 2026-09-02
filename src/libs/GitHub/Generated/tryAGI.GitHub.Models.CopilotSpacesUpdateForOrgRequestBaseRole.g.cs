
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The base role that determines default permissions for organization members. Changing this field requires admin permissions.<br/>
    /// - `no_access`: No default access (default)<br/>
    /// - `reader`: Organization members can read the space<br/>
    /// - `writer`: Organization members can read and edit the space<br/>
    /// - `admin`: Organization members have full admin access to the space
    /// </summary>
    public enum CopilotSpacesUpdateForOrgRequestBaseRole
    {
        /// <summary>
        /// Organization members have full admin access to the space
        /// </summary>
        Admin,
        /// <summary>
        /// No default access (default)
        /// </summary>
        NoAccess,
        /// <summary>
        /// Organization members can read the space
        /// </summary>
        Reader,
        /// <summary>
        /// Organization members can read and edit the space
        /// </summary>
        Writer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpacesUpdateForOrgRequestBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateForOrgRequestBaseRole value)
        {
            return value switch
            {
                CopilotSpacesUpdateForOrgRequestBaseRole.Admin => "admin",
                CopilotSpacesUpdateForOrgRequestBaseRole.NoAccess => "no_access",
                CopilotSpacesUpdateForOrgRequestBaseRole.Reader => "reader",
                CopilotSpacesUpdateForOrgRequestBaseRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateForOrgRequestBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesUpdateForOrgRequestBaseRole.Admin,
                "no_access" => CopilotSpacesUpdateForOrgRequestBaseRole.NoAccess,
                "reader" => CopilotSpacesUpdateForOrgRequestBaseRole.Reader,
                "writer" => CopilotSpacesUpdateForOrgRequestBaseRole.Writer,
                _ => null,
            };
        }
    }
}