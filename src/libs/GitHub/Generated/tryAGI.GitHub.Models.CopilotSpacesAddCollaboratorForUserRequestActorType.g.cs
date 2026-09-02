
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of actor (must be `User` for user-owned spaces; `Team` will be rejected).
    /// </summary>
    public enum CopilotSpacesAddCollaboratorForUserRequestActorType
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
    public static class CopilotSpacesAddCollaboratorForUserRequestActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesAddCollaboratorForUserRequestActorType value)
        {
            return value switch
            {
                CopilotSpacesAddCollaboratorForUserRequestActorType.Team => "Team",
                CopilotSpacesAddCollaboratorForUserRequestActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesAddCollaboratorForUserRequestActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesAddCollaboratorForUserRequestActorType.Team,
                "User" => CopilotSpacesAddCollaboratorForUserRequestActorType.User,
                _ => null,
            };
        }
    }
}