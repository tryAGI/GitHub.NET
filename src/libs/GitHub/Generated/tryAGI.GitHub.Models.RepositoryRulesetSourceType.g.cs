
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the source of the ruleset
    /// </summary>
    public enum RepositoryRulesetSourceType
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetSourceType value)
        {
            return value switch
            {
                RepositoryRulesetSourceType.Enterprise => "Enterprise",
                RepositoryRulesetSourceType.Organization => "Organization",
                RepositoryRulesetSourceType.Repository => "Repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetSourceType? ToEnum(string value)
        {
            return value switch
            {
                "Enterprise" => RepositoryRulesetSourceType.Enterprise,
                "Organization" => RepositoryRulesetSourceType.Organization,
                "Repository" => RepositoryRulesetSourceType.Repository,
                _ => null,
            };
        }
    }
}