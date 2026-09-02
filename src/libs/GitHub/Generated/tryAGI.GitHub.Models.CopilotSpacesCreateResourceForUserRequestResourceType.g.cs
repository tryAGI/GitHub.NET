
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource to create.
    /// </summary>
    public enum CopilotSpacesCreateResourceForUserRequestResourceType
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
    public static class CopilotSpacesCreateResourceForUserRequestResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateResourceForUserRequestResourceType value)
        {
            return value switch
            {
                CopilotSpacesCreateResourceForUserRequestResourceType.FreeText => "free_text",
                CopilotSpacesCreateResourceForUserRequestResourceType.GithubFile => "github_file",
                CopilotSpacesCreateResourceForUserRequestResourceType.GithubIssue => "github_issue",
                CopilotSpacesCreateResourceForUserRequestResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesCreateResourceForUserRequestResourceType.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateResourceForUserRequestResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesCreateResourceForUserRequestResourceType.FreeText,
                "github_file" => CopilotSpacesCreateResourceForUserRequestResourceType.GithubFile,
                "github_issue" => CopilotSpacesCreateResourceForUserRequestResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesCreateResourceForUserRequestResourceType.GithubPullRequest,
                "repository" => CopilotSpacesCreateResourceForUserRequestResourceType.Repository,
                _ => null,
            };
        }
    }
}