
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    public enum CopilotSpacesCreateForUserRequestResourcesAttributeResourceType
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
    public static class CopilotSpacesCreateForUserRequestResourcesAttributeResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateForUserRequestResourcesAttributeResourceType value)
        {
            return value switch
            {
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.FreeText => "free_text",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubFile => "github_file",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubIssue => "github_issue",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.MediaContent => "media_content",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.Repository => "repository",
                CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateForUserRequestResourcesAttributeResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.FreeText,
                "github_file" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubFile,
                "github_issue" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.GithubPullRequest,
                "media_content" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.MediaContent,
                "repository" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.Repository,
                "uploaded_text_file" => CopilotSpacesCreateForUserRequestResourcesAttributeResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}