
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    public enum CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType
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
    public static class CopilotSpacesCreateForOrgRequestResourcesAttributeResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType value)
        {
            return value switch
            {
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.FreeText => "free_text",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubFile => "github_file",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubIssue => "github_issue",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.MediaContent => "media_content",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.Repository => "repository",
                CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.FreeText,
                "github_file" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubFile,
                "github_issue" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.GithubPullRequest,
                "media_content" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.MediaContent,
                "repository" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.Repository,
                "uploaded_text_file" => CopilotSpacesCreateForOrgRequestResourcesAttributeResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}