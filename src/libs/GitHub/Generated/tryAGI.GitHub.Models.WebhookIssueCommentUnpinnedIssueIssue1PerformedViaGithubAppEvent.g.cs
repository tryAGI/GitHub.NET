
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule => "branch_protection_rule",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CheckRun => "check_run",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CheckSuite => "check_suite",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert => "code_scanning_alert",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CommitComment => "commit_comment",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ContentReference => "content_reference",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Create => "create",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Delete => "delete",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeployKey => "deploy_key",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Deployment => "deployment",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview => "deployment_review",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus => "deployment_status",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Discussion => "discussion",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment => "discussion_comment",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Fork => "fork",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Gollum => "gollum",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.IssueComment => "issue_comment",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Issues => "issues",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Label => "label",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Member => "member",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Membership => "membership",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Milestone => "milestone",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.OrgBlock => "org_block",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Organization => "organization",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PageBuild => "page_build",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Project => "project",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ProjectCard => "project_card",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn => "project_column",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Public => "public",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequest => "pull_request",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview => "pull_request_review",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment => "pull_request_review_comment",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Push => "push",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage => "registry_package",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Release => "release",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Repository => "repository",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch => "repository_dispatch",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert => "secret_scanning_alert",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Star => "star",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Status => "status",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Team => "team",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.TeamAdd => "team_add",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Watch => "watch",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch => "workflow_dispatch",
                WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun => "workflow_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent? ToEnum(string value)
        {
            return value switch
            {
                "branch_protection_rule" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.BranchProtectionRule,
                "check_run" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CheckRun,
                "check_suite" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CheckSuite,
                "code_scanning_alert" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CodeScanningAlert,
                "commit_comment" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.CommitComment,
                "content_reference" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ContentReference,
                "create" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Create,
                "delete" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Delete,
                "deploy_key" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeployKey,
                "deployment" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Deployment,
                "deployment_review" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentReview,
                "deployment_status" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DeploymentStatus,
                "discussion" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Discussion,
                "discussion_comment" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.DiscussionComment,
                "fork" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Fork,
                "gollum" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Gollum,
                "issue_comment" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.IssueComment,
                "issues" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Issues,
                "label" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Label,
                "member" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Member,
                "membership" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Membership,
                "milestone" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Milestone,
                "org_block" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.OrgBlock,
                "organization" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Organization,
                "page_build" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PageBuild,
                "project" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Project,
                "project_card" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ProjectCard,
                "project_column" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.ProjectColumn,
                "public" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Public,
                "pull_request" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequest,
                "pull_request_review" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReview,
                "pull_request_review_comment" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.PullRequestReviewComment,
                "push" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Push,
                "registry_package" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.RegistryPackage,
                "release" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Release,
                "repository" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Repository,
                "repository_dispatch" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.RepositoryDispatch,
                "secret_scanning_alert" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.SecretScanningAlert,
                "star" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Star,
                "status" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Status,
                "team" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Team,
                "team_add" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.TeamAdd,
                "watch" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.Watch,
                "workflow_dispatch" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowDispatch,
                "workflow_run" => WebhookIssueCommentUnpinnedIssueIssue1PerformedViaGithubAppEvent.WorkflowRun,
                _ => null,
            };
        }
    }
}