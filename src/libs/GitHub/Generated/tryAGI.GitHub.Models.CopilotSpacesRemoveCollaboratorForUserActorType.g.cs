
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CopilotSpacesRemoveCollaboratorForUserActorType
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
    public static class CopilotSpacesRemoveCollaboratorForUserActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesRemoveCollaboratorForUserActorType value)
        {
            return value switch
            {
                CopilotSpacesRemoveCollaboratorForUserActorType.Team => "Team",
                CopilotSpacesRemoveCollaboratorForUserActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesRemoveCollaboratorForUserActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesRemoveCollaboratorForUserActorType.Team,
                "User" => CopilotSpacesRemoveCollaboratorForUserActorType.User,
                _ => null,
            };
        }
    }
}