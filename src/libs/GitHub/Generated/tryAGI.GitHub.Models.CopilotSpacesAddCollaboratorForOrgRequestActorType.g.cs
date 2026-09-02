
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of actor (user or team).
    /// </summary>
    public enum CopilotSpacesAddCollaboratorForOrgRequestActorType
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
    public static class CopilotSpacesAddCollaboratorForOrgRequestActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesAddCollaboratorForOrgRequestActorType value)
        {
            return value switch
            {
                CopilotSpacesAddCollaboratorForOrgRequestActorType.Team => "Team",
                CopilotSpacesAddCollaboratorForOrgRequestActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesAddCollaboratorForOrgRequestActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesAddCollaboratorForOrgRequestActorType.Team,
                "User" => CopilotSpacesAddCollaboratorForOrgRequestActorType.User,
                _ => null,
            };
        }
    }
}