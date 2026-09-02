
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    public enum CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType
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
    public static class CopilotSpacesUpdateForUserRequestResourcesAttributeResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType value)
        {
            return value switch
            {
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.FreeText => "free_text",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubFile => "github_file",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubIssue => "github_issue",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.MediaContent => "media_content",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.Repository => "repository",
                CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.FreeText,
                "github_file" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubFile,
                "github_issue" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.GithubPullRequest,
                "media_content" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.MediaContent,
                "repository" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.Repository,
                "uploaded_text_file" => CopilotSpacesUpdateForUserRequestResourcesAttributeResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}