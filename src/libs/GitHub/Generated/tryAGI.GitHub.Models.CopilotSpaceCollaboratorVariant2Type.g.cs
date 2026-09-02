
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CopilotSpaceCollaboratorVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpaceCollaboratorVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceCollaboratorVariant2Type value)
        {
            return value switch
            {
                CopilotSpaceCollaboratorVariant2Type.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceCollaboratorVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "Team" => CopilotSpaceCollaboratorVariant2Type.Team,
                _ => null,
            };
        }
    }
}