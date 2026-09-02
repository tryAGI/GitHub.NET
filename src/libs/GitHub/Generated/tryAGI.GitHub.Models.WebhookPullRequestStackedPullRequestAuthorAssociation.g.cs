
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestAuthorAssociation
    {
        /// <summary>
        ///
        /// </summary>
        Collaborator,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        FirstTimer,
        /// <summary>
        ///
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        ///
        /// </summary>
        Mannequin,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestStackedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestStackedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestStackedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestStackedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestStackedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestStackedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestStackedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestStackedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestStackedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestStackedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestStackedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestStackedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestStackedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestStackedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestStackedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}