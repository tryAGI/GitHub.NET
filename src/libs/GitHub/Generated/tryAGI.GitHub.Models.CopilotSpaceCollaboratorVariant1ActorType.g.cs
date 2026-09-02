
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The collaborator actor type.
    /// </summary>
    public enum CopilotSpaceCollaboratorVariant1ActorType
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpaceCollaboratorVariant1ActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceCollaboratorVariant1ActorType value)
        {
            return value switch
            {
                CopilotSpaceCollaboratorVariant1ActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceCollaboratorVariant1ActorType? ToEnum(string value)
        {
            return value switch
            {
                "User" => CopilotSpaceCollaboratorVariant1ActorType.User,
                _ => null,
            };
        }
    }
}