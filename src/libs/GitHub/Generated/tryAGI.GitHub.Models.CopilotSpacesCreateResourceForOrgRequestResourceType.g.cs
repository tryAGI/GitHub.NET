
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource to create.
    /// </summary>
    public enum CopilotSpacesCreateResourceForOrgRequestResourceType
    {
        /// <summary>
        ///
        /// </summary>
        FreeText,
        /// <summary>
        ///
        /// </summary>
        GithubFile,
        /// <summary>
        ///
        /// </summary>
        GithubIssue,
        /// <summary>
        ///
        /// </summary>
        GithubPullRequest,
        /// <summary>
        ///
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpacesCreateResourceForOrgRequestResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateResourceForOrgRequestResourceType value)
        {
            return value switch
            {
                CopilotSpacesCreateResourceForOrgRequestResourceType.FreeText => "free_text",
                CopilotSpacesCreateResourceForOrgRequestResourceType.GithubFile => "github_file",
                CopilotSpacesCreateResourceForOrgRequestResourceType.GithubIssue => "github_issue",
                CopilotSpacesCreateResourceForOrgRequestResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesCreateResourceForOrgRequestResourceType.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateResourceForOrgRequestResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesCreateResourceForOrgRequestResourceType.FreeText,
                "github_file" => CopilotSpacesCreateResourceForOrgRequestResourceType.GithubFile,
                "github_issue" => CopilotSpacesCreateResourceForOrgRequestResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesCreateResourceForOrgRequestResourceType.GithubPullRequest,
                "repository" => CopilotSpacesCreateResourceForOrgRequestResourceType.Repository,
                _ => null,
            };
        }
    }
}