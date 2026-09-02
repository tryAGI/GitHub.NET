
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The base role that determines default permissions for the space. Changing this field requires admin permissions.<br/>
    /// - `no_access`: No default access (default)<br/>
    /// - `reader`: Makes the space publicly readable<br/>
    /// Note: User spaces do not support writer or admin base roles.
    /// </summary>
    public enum CopilotSpacesUpdateForUserRequestBaseRole
    {
        /// <summary>
        /// No default access (default)
        /// </summary>
        NoAccess,
        /// <summary>
        /// Makes the space publicly readable
        /// </summary>
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpacesUpdateForUserRequestBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateForUserRequestBaseRole value)
        {
            return value switch
            {
                CopilotSpacesUpdateForUserRequestBaseRole.NoAccess => "no_access",
                CopilotSpacesUpdateForUserRequestBaseRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateForUserRequestBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "no_access" => CopilotSpacesUpdateForUserRequestBaseRole.NoAccess,
                "reader" => CopilotSpacesUpdateForUserRequestBaseRole.Reader,
                _ => null,
            };
        }
    }
}