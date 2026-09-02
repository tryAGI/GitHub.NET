
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The collaborator actor type.
    /// </summary>
    public enum CopilotSpaceCollaboratorVariant2ActorType
    {
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpaceCollaboratorVariant2ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceCollaboratorVariant2ActorType value)
        {
            return value switch
            {
                CopilotSpaceCollaboratorVariant2ActorType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceCollaboratorVariant2ActorType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpaceCollaboratorVariant2ActorType.Team,
                _ => null,
            };
        }
    }
}