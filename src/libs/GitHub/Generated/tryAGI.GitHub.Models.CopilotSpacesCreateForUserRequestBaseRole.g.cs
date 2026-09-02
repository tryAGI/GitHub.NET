
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The base role that determines default permissions for the space.<br/>
    /// - `no_access`: No default access (default)<br/>
    /// - `reader`: Makes the space publicly readable<br/>
    /// Note: User spaces do not support writer or admin base roles.<br/>
    /// Default Value: no_access
    /// </summary>
    public enum CopilotSpacesCreateForUserRequestBaseRole
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
    public static class CopilotSpacesCreateForUserRequestBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateForUserRequestBaseRole value)
        {
            return value switch
            {
                CopilotSpacesCreateForUserRequestBaseRole.NoAccess => "no_access",
                CopilotSpacesCreateForUserRequestBaseRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateForUserRequestBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "no_access" => CopilotSpacesCreateForUserRequestBaseRole.NoAccess,
                "reader" => CopilotSpacesCreateForUserRequestBaseRole.Reader,
                _ => null,
            };
        }
    }
}