
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the actor
    /// </summary>
    public enum RepositoryRuleParamsActorType
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationInstallation,
        /// <summary>
        ///
        /// </summary>
        RepositoryRole,
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
    public static class RepositoryRuleParamsActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleParamsActorType value)
        {
            return value switch
            {
                RepositoryRuleParamsActorType.IntegrationInstallation => "IntegrationInstallation",
                RepositoryRuleParamsActorType.RepositoryRole => "RepositoryRole",
                RepositoryRuleParamsActorType.Team => "Team",
                RepositoryRuleParamsActorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleParamsActorType? ToEnum(string value)
        {
            return value switch
            {
                "IntegrationInstallation" => RepositoryRuleParamsActorType.IntegrationInstallation,
                "RepositoryRole" => RepositoryRuleParamsActorType.RepositoryRole,
                "Team" => RepositoryRuleParamsActorType.Team,
                "User" => RepositoryRuleParamsActorType.User,
                _ => null,
            };
        }
    }
}