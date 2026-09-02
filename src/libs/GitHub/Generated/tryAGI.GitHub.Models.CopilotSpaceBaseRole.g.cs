
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The base role that determines default permissions.<br/>
    /// - `no_access`: No default access<br/>
    /// - `reader`: Default read permissions<br/>
    /// - `writer`: Default write permissions (organization spaces only)<br/>
    /// - `admin`: Default admin permissions (organization spaces only)<br/>
    /// Example: no_access
    /// </summary>
    public enum CopilotSpaceBaseRole
    {
        /// <summary>
        /// Default admin permissions (organization spaces only)
        /// </summary>
        Admin,
        /// <summary>
        /// No default access
        /// </summary>
        NoAccess,
        /// <summary>
        /// Default read permissions
        /// </summary>
        Reader,
        /// <summary>
        /// Default write permissions (organization spaces only)
        /// </summary>
        Writer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpaceBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceBaseRole value)
        {
            return value switch
            {
                CopilotSpaceBaseRole.Admin => "admin",
                CopilotSpaceBaseRole.NoAccess => "no_access",
                CopilotSpaceBaseRole.Reader => "reader",
                CopilotSpaceBaseRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpaceBaseRole.Admin,
                "no_access" => CopilotSpaceBaseRole.NoAccess,
                "reader" => CopilotSpaceBaseRole.Reader,
                "writer" => CopilotSpaceBaseRole.Writer,
                _ => null,
            };
        }
    }
}