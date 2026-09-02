
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiInsightsGetSummaryStatsByActorActorType
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
    public static class ApiInsightsGetSummaryStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetSummaryStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetSummaryStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetSummaryStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
                ApiInsightsGetSummaryStatsByActorActorType.Installation => "installation",
                ApiInsightsGetSummaryStatsByActorActorType.OauthApp => "oauth_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetSummaryStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "classic_pat" => ApiInsightsGetSummaryStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPat,
                "github_app_user_to_server" => ApiInsightsGetSummaryStatsByActorActorType.GithubAppUserToServer,
                "installation" => ApiInsightsGetSummaryStatsByActorActorType.Installation,
                "oauth_app" => ApiInsightsGetSummaryStatsByActorActorType.OauthApp,
                _ => null,
            };
        }
    }
}