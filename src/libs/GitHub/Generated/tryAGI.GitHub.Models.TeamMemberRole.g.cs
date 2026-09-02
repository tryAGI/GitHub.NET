
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The member's role on the team. Only present on the `List team members` endpoint, and only when the feature is enabled for the organization.<br/>
    /// Example: member
    /// </summary>
    public enum TeamMemberRole
    {
        /// <summary>
        ///
        /// </summary>
        Maintainer,
        /// <summary>
        ///
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMemberRole value)
        {
            return value switch
            {
                TeamMemberRole.Maintainer => "maintainer",
                TeamMemberRole.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "maintainer" => TeamMemberRole.Maintainer,
                "member" => TeamMemberRole.Member,
                _ => null,
            };
        }
    }
}