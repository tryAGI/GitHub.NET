
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiInsightsGetRouteStatsByActorActorType
    {
        /// <summary>
        ///
        /// </summary>
        ClassicPat,
        /// <summary>
        ///
        /// </summary>
        FineGrainedPat,
        /// <summary>
        ///
        /// </summary>
        GithubAppUserToServer,
        /// <summary>
        ///
        /// </summary>
        Installation,
        /// <summary>
        ///
        /// </summary>
        OauthApp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetRouteStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetRouteStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetRouteStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetRouteStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetRouteStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
                ApiInsightsGetRouteStatsByActorActorType.Installation => "installation",
                ApiInsightsGetRouteStatsByActorActorType.OauthApp => "oauth_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetRouteStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "classic_pat" => ApiInsightsGetRouteStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetRouteStatsByActorActorType.FineGrainedPat,
                "github_app_user_to_server" => ApiInsightsGetRouteStatsByActorActorType.GithubAppUserToServer,
                "installation" => ApiInsightsGetRouteStatsByActorActorType.Installation,
                "oauth_app" => ApiInsightsGetRouteStatsByActorActorType.OauthApp,
                _ => null,
            };
        }
    }
}