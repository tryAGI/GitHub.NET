
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CopilotSpacesRemoveCollaboratorForOrgActorType
    {
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpacesRemoveCollaboratorForOrgActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesRemoveCollaboratorForOrgActorType value)
        {
            return value switch
            {
                CopilotSpacesRemoveCollaboratorForOrgActorType.Team => "Team",
                CopilotSpacesRemoveCollaboratorForOrgActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesRemoveCollaboratorForOrgActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesRemoveCollaboratorForOrgActorType.Team,
                "User" => CopilotSpacesRemoveCollaboratorForOrgActorType.User,
                _ => null,
            };
        }
    }
}