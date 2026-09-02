
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestBaseRepoVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestBaseRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestBaseRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestBaseRepoVisibility.Internal => "internal",
                WebhookPullRequestStackedPullRequestBaseRepoVisibility.Private => "private",
                WebhookPullRequestStackedPullRequestBaseRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestBaseRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestStackedPullRequestBaseRepoVisibility.Internal,
                "private" => WebhookPullRequestStackedPullRequestBaseRepoVisibility.Private,
                "public" => WebhookPullRequestStackedPullRequestBaseRepoVisibility.Public,
                _ => null,
            };
        }
    }
}