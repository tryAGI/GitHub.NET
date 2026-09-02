
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CopilotSpacesUpdateCollaboratorForUserActorType
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
    public static class CopilotSpacesUpdateCollaboratorForUserActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateCollaboratorForUserActorType value)
        {
            return value switch
            {
                CopilotSpacesUpdateCollaboratorForUserActorType.Team => "Team",
                CopilotSpacesUpdateCollaboratorForUserActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateCollaboratorForUserActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesUpdateCollaboratorForUserActorType.Team,
                "User" => CopilotSpacesUpdateCollaboratorForUserActorType.User,
                _ => null,
            };
        }
    }
}