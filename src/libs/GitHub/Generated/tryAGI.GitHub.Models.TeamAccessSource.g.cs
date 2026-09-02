
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// How the team's access to the repository was granted. This property is only<br/>
    /// present when the team is returned in a repository context, such as<br/>
    /// `GET /repos/{owner}/{repo}/teams`.<br/>
    /// Example: direct
    /// </summary>
    public enum TeamAccessSource
    {
        /// <summary>
        ///
        /// </summary>
        Direct,
        /// <summary>
        ///
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
    public static class TeamAccessSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamAccessSource value)
        {
            return value switch
            {
                TeamAccessSource.Direct => "direct",
                TeamAccessSource.Enterprise => "enterprise",
                TeamAccessSource.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamAccessSource? ToEnum(string value)
        {
            return value switch
            {
                "direct" => TeamAccessSource.Direct,
                "enterprise" => TeamAccessSource.Enterprise,
                "organization" => TeamAccessSource.Organization,
                _ => null,
            };
        }
    }
}