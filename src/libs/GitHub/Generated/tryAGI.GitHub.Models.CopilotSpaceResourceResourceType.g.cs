
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the resource.
    /// </summary>
    public enum CopilotSpaceResourceResourceType
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
        MediaContent,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        UploadedTextFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSpaceResourceResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceResourceResourceType value)
        {
            return value switch
            {
                CopilotSpaceResourceResourceType.FreeText => "free_text",
                CopilotSpaceResourceResourceType.GithubFile => "github_file",
                CopilotSpaceResourceResourceType.GithubIssue => "github_issue",
                CopilotSpaceResourceResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpaceResourceResourceType.MediaContent => "media_content",
                CopilotSpaceResourceResourceType.Repository => "repository",
                CopilotSpaceResourceResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceResourceResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpaceResourceResourceType.FreeText,
                "github_file" => CopilotSpaceResourceResourceType.GithubFile,
                "github_issue" => CopilotSpaceResourceResourceType.GithubIssue,
                "github_pull_request" => CopilotSpaceResourceResourceType.GithubPullRequest,
                "media_content" => CopilotSpaceResourceResourceType.MediaContent,
                "repository" => CopilotSpaceResourceResourceType.Repository,
                "uploaded_text_file" => CopilotSpaceResourceResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}