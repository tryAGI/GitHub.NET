
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CopilotSpacesUpdateCollaboratorForOrgActorType
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
    public static class CopilotSpacesUpdateCollaboratorForOrgActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateCollaboratorForOrgActorType value)
        {
            return value switch
            {
                CopilotSpacesUpdateCollaboratorForOrgActorType.Team => "Team",
                CopilotSpacesUpdateCollaboratorForOrgActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateCollaboratorForOrgActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpacesUpdateCollaboratorForOrgActorType.Team,
                "User" => CopilotSpacesUpdateCollaboratorForOrgActorType.User,
                _ => null,
            };
        }
    }
}