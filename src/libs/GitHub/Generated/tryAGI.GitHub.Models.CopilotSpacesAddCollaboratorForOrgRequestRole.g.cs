
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The role to grant to the collaborator.
    /// </summary>
    public enum CopilotSpacesAddCollaboratorForOrgRequestRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
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
    public static class CopilotSpacesAddCollaboratorForOrgRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesAddCollaboratorForOrgRequestRole value)
        {
            return value switch
            {
                CopilotSpacesAddCollaboratorForOrgRequestRole.Admin => "admin",
                CopilotSpacesAddCollaboratorForOrgRequestRole.Reader => "reader",
                CopilotSpacesAddCollaboratorForOrgRequestRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesAddCollaboratorForOrgRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesAddCollaboratorForOrgRequestRole.Admin,
                "reader" => CopilotSpacesAddCollaboratorForOrgRequestRole.Reader,
                "writer" => CopilotSpacesAddCollaboratorForOrgRequestRole.Writer,
                _ => null,
            };
        }
    }
}