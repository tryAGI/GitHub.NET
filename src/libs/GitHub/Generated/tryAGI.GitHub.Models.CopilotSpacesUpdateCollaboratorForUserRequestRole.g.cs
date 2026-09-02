
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
    /// </summary>
    public enum CopilotSpacesUpdateCollaboratorForUserRequestRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        NoAccess,
        /// <summary>
        ///
        /// </summary>
        Reader,
        /// <summary>
        ///
        /// </summary>
        Writer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpacesUpdateCollaboratorForUserRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateCollaboratorForUserRequestRole value)
        {
            return value switch
            {
                CopilotSpacesUpdateCollaboratorForUserRequestRole.Admin => "admin",
                CopilotSpacesUpdateCollaboratorForUserRequestRole.NoAccess => "no_access",
                CopilotSpacesUpdateCollaboratorForUserRequestRole.Reader => "reader",
                CopilotSpacesUpdateCollaboratorForUserRequestRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateCollaboratorForUserRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesUpdateCollaboratorForUserRequestRole.Admin,
                "no_access" => CopilotSpacesUpdateCollaboratorForUserRequestRole.NoAccess,
                "reader" => CopilotSpacesUpdateCollaboratorForUserRequestRole.Reader,
                "writer" => CopilotSpacesUpdateCollaboratorForUserRequestRole.Writer,
                _ => null,
            };
        }
    }
}