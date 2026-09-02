
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The role granted to the collaborator
    /// </summary>
    public enum CopilotSpaceCollaboratorVariant1Role
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
    public static class CopilotSpaceCollaboratorVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceCollaboratorVariant1Role value)
        {
            return value switch
            {
                CopilotSpaceCollaboratorVariant1Role.Admin => "admin",
                CopilotSpaceCollaboratorVariant1Role.Reader => "reader",
                CopilotSpaceCollaboratorVariant1Role.Writer => "writer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceCollaboratorVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CopilotSpaceCollaboratorVariant1Role.Admin,
                "reader" => CopilotSpaceCollaboratorVariant1Role.Reader,
                "writer" => CopilotSpaceCollaboratorVariant1Role.Writer,
                _ => null,
            };
        }
    }
}