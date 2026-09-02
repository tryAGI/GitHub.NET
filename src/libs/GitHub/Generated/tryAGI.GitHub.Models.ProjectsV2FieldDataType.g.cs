
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsV2FieldDataType
    {
        /// <summary>
        ///
        /// </summary>
        Assignees,
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        IssueType,
        /// <summary>
        ///
        /// </summary>
        Iteration,
        /// <summary>
        ///
        /// </summary>
        Labels,
        /// <summary>
        ///
        /// </summary>
        LinkedPullRequests,
        /// <summary>
        ///
        /// </summary>
        Milestone,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        ParentIssue,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        Reviewers,
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
        /// <summary>
        ///
        /// </summary>
        SubIssuesProgress,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2FieldDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2FieldDataType value)
        {
            return value switch
            {
                ProjectsV2FieldDataType.Assignees => "assignees",
                ProjectsV2FieldDataType.Date => "date",
                ProjectsV2FieldDataType.IssueType => "issue_type",
                ProjectsV2FieldDataType.Iteration => "iteration",
                ProjectsV2FieldDataType.Labels => "labels",
                ProjectsV2FieldDataType.LinkedPullRequests => "linked_pull_requests",
                ProjectsV2FieldDataType.Milestone => "milestone",
                ProjectsV2FieldDataType.Number => "number",
                ProjectsV2FieldDataType.ParentIssue => "parent_issue",
                ProjectsV2FieldDataType.Repository => "repository",
                ProjectsV2FieldDataType.Reviewers => "reviewers",
                ProjectsV2FieldDataType.SingleSelect => "single_select",
                ProjectsV2FieldDataType.SubIssuesProgress => "sub_issues_progress",
                ProjectsV2FieldDataType.Text => "text",
                ProjectsV2FieldDataType.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2FieldDataType? ToEnum(string value)
        {
            return value switch
            {
                "assignees" => ProjectsV2FieldDataType.Assignees,
                "date" => ProjectsV2FieldDataType.Date,
                "issue_type" => ProjectsV2FieldDataType.IssueType,
                "iteration" => ProjectsV2FieldDataType.Iteration,
                "labels" => ProjectsV2FieldDataType.Labels,
                "linked_pull_requests" => ProjectsV2FieldDataType.LinkedPullRequests,
                "milestone" => ProjectsV2FieldDataType.Milestone,
                "number" => ProjectsV2FieldDataType.Number,
                "parent_issue" => ProjectsV2FieldDataType.ParentIssue,
                "repository" => ProjectsV2FieldDataType.Repository,
                "reviewers" => ProjectsV2FieldDataType.Reviewers,
                "single_select" => ProjectsV2FieldDataType.SingleSelect,
                "sub_issues_progress" => ProjectsV2FieldDataType.SubIssuesProgress,
                "text" => ProjectsV2FieldDataType.Text,
                "title" => ProjectsV2FieldDataType.Title,
                _ => null,
            };
        }
    }
}