
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestReviewCommentEventCommentUserType
    {
        /// <summary>
        ///
        /// </summary>
        Bot,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestReviewCommentEventCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewCommentEventCommentUserType value)
        {
            return value switch
            {
                PullRequestReviewCommentEventCommentUserType.Bot => "Bot",
                PullRequestReviewCommentEventCommentUserType.Organization => "Organization",
                PullRequestReviewCommentEventCommentUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewCommentEventCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => PullRequestReviewCommentEventCommentUserType.Bot,
                "Organization" => PullRequestReviewCommentEventCommentUserType.Organization,
                "User" => PullRequestReviewCommentEventCommentUserType.User,
                _ => null,
            };
        }
    }
}