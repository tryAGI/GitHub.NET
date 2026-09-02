
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestHeadRepoVisibility
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
    public static class WebhookPullRequestStackedPullRequestHeadRepoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestHeadRepoVisibility value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestHeadRepoVisibility.Internal => "internal",
                WebhookPullRequestStackedPullRequestHeadRepoVisibility.Private => "private",
                WebhookPullRequestStackedPullRequestHeadRepoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestHeadRepoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookPullRequestStackedPullRequestHeadRepoVisibility.Internal,
                "private" => WebhookPullRequestStackedPullRequestHeadRepoVisibility.Private,
                "public" => WebhookPullRequestStackedPullRequestHeadRepoVisibility.Public,
                _ => null,
            };
        }
    }
}