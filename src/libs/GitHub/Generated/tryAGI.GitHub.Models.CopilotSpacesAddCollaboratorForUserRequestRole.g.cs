
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The role to grant to the collaborator.
    /// </summary>
    public enum CopilotSpacesAddCollaboratorForUserRequestRole
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
    public static class CopilotSpacesAddCollaboratorForUserRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesAddCollaboratorForUserRequestRole value)
        {
            return value switch
            {
                CopilotSpacesAddCollaboratorForUserRequestRole.Admin => "admin",
                CopilotSpacesAddCollaboratorForUserRequestRole.Reader => "reader",
                CopilotSpacesAddCollaboratorForUserRequestRole.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesAddCollaboratorForUserRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpacesAddCollaboratorForUserRequestRole.Admin,
                "reader" => CopilotSpacesAddCollaboratorForUserRequestRole.Reader,
                "writer" => CopilotSpacesAddCollaboratorForUserRequestRole.Writer,
                _ => null,
            };
        }
    }
}