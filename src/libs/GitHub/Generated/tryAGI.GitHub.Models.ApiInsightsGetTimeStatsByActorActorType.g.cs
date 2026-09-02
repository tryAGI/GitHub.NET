
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiInsightsGetTimeStatsByActorActorType
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
    public static class ApiInsightsGetTimeStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetTimeStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetTimeStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetTimeStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetTimeStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
                ApiInsightsGetTimeStatsByActorActorType.Installation => "installation",
                ApiInsightsGetTimeStatsByActorActorType.OauthApp => "oauth_app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetTimeStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "classic_pat" => ApiInsightsGetTimeStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetTimeStatsByActorActorType.FineGrainedPat,
                "github_app_user_to_server" => ApiInsightsGetTimeStatsByActorActorType.GithubAppUserToServer,
                "installation" => ApiInsightsGetTimeStatsByActorActorType.Installation,
                "oauth_app" => ApiInsightsGetTimeStatsByActorActorType.OauthApp,
                _ => null,
            };
        }
    }
}