
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent
    {
        /// <summary>
        ///
        /// </summary>
        BranchProtectionRule,
        /// <summary>
        ///
        /// </summary>
        CheckRun,
        /// <summary>
        ///
        /// </summary>
        CheckSuite,
        /// <summary>
        ///
        /// </summary>
        CodeScanningAlert,
        /// <summary>
        ///
        /// </summary>
        CommitComment,
        /// <summary>
        ///
        /// </summary>
        ContentReference,
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        DeployKey,
        /// <summary>
        ///
        /// </summary>
        Deployment,
        /// <summary>
        ///
        /// </summary>
        DeploymentReview,
        /// <summary>
        ///
        /// </summary>
        DeploymentStatus,
        /// <summary>
        ///
        /// </summary>
        Discussion,
        /// <summary>
        ///
        /// </summary>
        DiscussionComment,
        /// <summary>
        ///
        /// </summary>
        Fork,
        /// <summary>
        ///
        /// </summary>
        Gollum,
        /// <summary>
        ///
        /// </summary>
        IssueComment,
        /// <summary>
        ///
        /// </summary>
        Issues,
        /// <summary>
        ///
        /// </summary>
        Label,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Membership,
        /// <summary>
        ///
        /// </summary>
        Milestone,
        /// <summary>
        ///
        /// </summary>
        OrgBlock,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        PageBuild,
        /// <summary>
        ///
        /// </summary>
        Project,
        /// <summary>
        ///
        /// </summary>
        ProjectCard,
        /// <summary>
        ///
        /// </summary>
        ProjectColumn,
        /// <summary>
        ///
        /// </summary>
        Public,
        /// <summary>
        ///
        /// </summary>
        PullRequest,
        /// <summary>
        ///
        /// </summary>
        PullRequestReview,
        /// <summary>
        ///
        /// </summary>
        PullRequestReviewComment,
        /// <summary>
        ///
        /// </summary>
        Push,
        /// <summary>
        ///
        /// </summary>
        RegistryPackage,
        /// <summary>
        ///
        /// </summary>
        Release,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        RepositoryDispatch,
        /// <summary>
        ///
        /// </summary>
        SecretScanningAlert,
        /// <summary>
        ///
        /// </summary>
        Star,
        /// <summary>
        ///
        /// </summary>
        Status,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        TeamAdd,
        /// <summary>
        ///
        /// </summary>
        Watch,
        /// <summary>
        ///
        /// </summary>
        WorkflowDispatch,
        /// <summary>
        ///
        /// </summary>
        WorkflowRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentPinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}