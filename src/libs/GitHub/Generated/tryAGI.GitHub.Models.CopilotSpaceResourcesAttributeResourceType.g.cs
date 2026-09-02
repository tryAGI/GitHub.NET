
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    public enum CopilotSpaceResourcesAttributeResourceType
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
    public static class CopilotSpaceResourcesAttributeResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpaceResourcesAttributeResourceType value)
        {
            return value switch
            {
                CopilotSpaceResourcesAttributeResourceType.FreeText => "free_text",
                CopilotSpaceResourcesAttributeResourceType.GithubFile => "github_file",
                CopilotSpaceResourcesAttributeResourceType.GithubIssue => "github_issue",
                CopilotSpaceResourcesAttributeResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpaceResourcesAttributeResourceType.MediaContent => "media_content",
                CopilotSpaceResourcesAttributeResourceType.Repository => "repository",
                CopilotSpaceResourcesAttributeResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpaceResourcesAttributeResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpaceResourcesAttributeResourceType.FreeText,
                "github_file" => CopilotSpaceResourcesAttributeResourceType.GithubFile,
                "github_issue" => CopilotSpaceResourcesAttributeResourceType.GithubIssue,
                "github_pull_request" => CopilotSpaceResourcesAttributeResourceType.GithubPullRequest,
                "media_content" => CopilotSpaceResourcesAttributeResourceType.MediaContent,
                "repository" => CopilotSpaceResourcesAttributeResourceType.Repository,
                "uploaded_text_file" => CopilotSpaceResourcesAttributeResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}