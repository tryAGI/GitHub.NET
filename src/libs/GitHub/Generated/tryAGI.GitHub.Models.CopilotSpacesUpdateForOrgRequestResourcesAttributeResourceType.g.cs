
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of resource.
    /// </summary>
    public enum CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType
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
    public static class CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType value)
        {
            return value switch
            {
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.FreeText => "free_text",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubFile => "github_file",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubIssue => "github_issue",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubPullRequest => "github_pull_request",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.MediaContent => "media_content",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.Repository => "repository",
                CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.UploadedTextFile => "uploaded_text_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType? ToEnum(string value)
        {
            return value switch
            {
                "free_text" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.FreeText,
                "github_file" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubFile,
                "github_issue" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubIssue,
                "github_pull_request" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.GithubPullRequest,
                "media_content" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.MediaContent,
                "repository" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.Repository,
                "uploaded_text_file" => CopilotSpacesUpdateForOrgRequestResourcesAttributeResourceType.UploadedTextFile,
                _ => null,
            };
        }
    }
}