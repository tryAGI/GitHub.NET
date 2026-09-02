
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The role granted to the collaborator
    /// </summary>
    public enum CopilotSpaceCollaboratorVariant2Role
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
    public static class CopilotSpaceCollaboratorVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceCollaboratorVariant2Role value)
        {
            return value switch
            {
                CopilotSpaceCollaboratorVariant2Role.Admin => "admin",
                CopilotSpaceCollaboratorVariant2Role.Reader => "reader",
                CopilotSpaceCollaboratorVariant2Role.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceCollaboratorVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpaceCollaboratorVariant2Role.Admin,
                "reader" => CopilotSpaceCollaboratorVariant2Role.Reader,
                "writer" => CopilotSpaceCollaboratorVariant2Role.Writer,
                _ => null,
            };
        }
    }
}