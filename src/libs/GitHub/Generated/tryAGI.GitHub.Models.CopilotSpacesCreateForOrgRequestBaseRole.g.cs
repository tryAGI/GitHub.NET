
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The base role that determines default permissions for organization members.<br/>
    /// - `no_access`: No default access (default)<br/>
    /// - `reader`: Organization members can read the space<br/>
    /// - `writer`: Organization members can read and edit the space<br/>
    /// - `admin`: Organization members have full admin access to the space<br/>
    /// Default Value: no_access
    /// </summary>
    public enum CopilotSpacesCreateForOrgRequestBaseRole
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
    public static class CopilotSpacesCreateForOrgRequestBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateForOrgRequestBaseRole value)
        {
            return value switch
            {
                CopilotSpacesCreateForOrgRequestBaseRole.Admin => "admin",
                CopilotSpacesCreateForOrgRequestBaseRole.NoAccess => "no_access",
                CopilotSpacesCreateForOrgRequestBaseRole.Reader => "reader",
                CopilotSpacesCreateForOrgRequestBaseRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateForOrgRequestBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesCreateForOrgRequestBaseRole.Admin,
                "no_access" => CopilotSpacesCreateForOrgRequestBaseRole.NoAccess,
                "reader" => CopilotSpacesCreateForOrgRequestBaseRole.Reader,
                "writer" => CopilotSpacesCreateForOrgRequestBaseRole.Writer,
                _ => null,
            };
        }
    }
}