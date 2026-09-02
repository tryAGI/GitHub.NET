
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage
    {
        /// <summary>
        ///
        /// </summary>
        Blank,
        /// <summary>
        ///
        /// </summary>
        CommitMessages,
        /// <summary>
        ///
        /// </summary>
        PrBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.Blank => "BLANK",
                WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => WebhookPullRequestStackedPullRequestBaseRepoSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}