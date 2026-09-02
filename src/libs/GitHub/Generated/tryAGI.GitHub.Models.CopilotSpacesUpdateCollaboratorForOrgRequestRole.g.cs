
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The new role to grant to the collaborator. Use `no_access` to remove the collaborator.
    /// </summary>
    public enum CopilotSpacesUpdateCollaboratorForOrgRequestRole
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
    public static class CopilotSpacesUpdateCollaboratorForOrgRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateCollaboratorForOrgRequestRole value)
        {
            return value switch
            {
                CopilotSpacesUpdateCollaboratorForOrgRequestRole.Admin => "admin",
                CopilotSpacesUpdateCollaboratorForOrgRequestRole.NoAccess => "no_access",
                CopilotSpacesUpdateCollaboratorForOrgRequestRole.Reader => "reader",
                CopilotSpacesUpdateCollaboratorForOrgRequestRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateCollaboratorForOrgRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesUpdateCollaboratorForOrgRequestRole.Admin,
                "no_access" => CopilotSpacesUpdateCollaboratorForOrgRequestRole.NoAccess,
                "reader" => CopilotSpacesUpdateCollaboratorForOrgRequestRole.Reader,
                "writer" => CopilotSpacesUpdateCollaboratorForOrgRequestRole.Writer,
                _ => null,
            };
        }
    }
}