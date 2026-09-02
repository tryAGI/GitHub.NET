
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy that controls when fork PR workflows require approval from a maintainer.
    /// </summary>
    public enum ActionsForkPrContributorApprovalApprovalPolicy
    {
        /// <summary>
        ///
        /// </summary>
        AllExternalContributors,
        /// <summary>
        ///
        /// </summary>
        FirstTimeContributors,
        /// <summary>
        ///
        /// </summary>
        FirstTimeContributorsNewToGithub,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsForkPrContributorApprovalApprovalPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsForkPrContributorApprovalApprovalPolicy value)
        {
            return value switch
            {
                ActionsForkPrContributorApprovalApprovalPolicy.AllExternalContributors => "all_external_contributors",
                ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributors => "first_time_contributors",
                ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributorsNewToGithub => "first_time_contributors_new_to_github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsForkPrContributorApprovalApprovalPolicy? ToEnum(string value)
        {
            return value switch
            {
                "all_external_contributors" => ActionsForkPrContributorApprovalApprovalPolicy.AllExternalContributors,
                "first_time_contributors" => ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributors,
                "first_time_contributors_new_to_github" => ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributorsNewToGithub,
                _ => null,
            };
        }
    }
}