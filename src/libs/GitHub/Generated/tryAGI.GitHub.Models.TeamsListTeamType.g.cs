
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum TeamsListTeamType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        /// //docs.github.com/enterprise-cloud@latest/admin/concepts/enterprise-fundamentals/teams-in-an-enterprise#what-kind-of-team-should-i-use)"
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsListTeamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListTeamType value)
        {
            return value switch
            {
                TeamsListTeamType.All => "all",
                TeamsListTeamType.Enterprise => "enterprise",
                TeamsListTeamType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListTeamType? ToEnum(string value)
        {
            return value switch
            {
                "all" => TeamsListTeamType.All,
                "enterprise" => TeamsListTeamType.Enterprise,
                "organization" => TeamsListTeamType.Organization,
                _ => null,
            };
        }
    }
}