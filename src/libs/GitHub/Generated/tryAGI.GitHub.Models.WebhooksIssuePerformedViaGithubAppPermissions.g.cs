
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhooksIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="administration"></param>
        /// <param name="checks"></param>
        /// <param name="contentReferences"></param>
        /// <param name="contents"></param>
        /// <param name="deployments"></param>
        /// <param name="discussions"></param>
        /// <param name="emails"></param>
        /// <param name="environments"></param>
        /// <param name="issues"></param>
        /// <param name="keys"></param>
        /// <param name="members"></param>
        /// <param name="metadata"></param>
        /// <param name="organizationAdministration"></param>
        /// <param name="organizationHooks"></param>
        /// <param name="organizationPackages"></param>
        /// <param name="organizationPlan"></param>
        /// <param name="organizationProjects"></param>
        /// <param name="organizationSecrets"></param>
        /// <param name="organizationSelfHostedRunners"></param>
        /// <param name="organizationUserBlocking"></param>
        /// <param name="packages"></param>
        /// <param name="pages"></param>
        /// <param name="pullRequests"></param>
        /// <param name="repositoryHooks"></param>
        /// <param name="repositoryProjects"></param>
        /// <param name="secretScanningAlerts"></param>
        /// <param name="secrets"></param>
        /// <param name="securityEvents"></param>
        /// <param name="securityScanningAlert"></param>
        /// <param name="singleFile"></param>
        /// <param name="statuses"></param>
        /// <param name="vulnerabilityAlerts"></param>
        /// <param name="workflows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksIssuePerformedViaGithubAppPermissions(
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsActions? actions,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContents? contents,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMembers? members,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPages? pages,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::tryAGI.GitHub.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.ContentReferences = contentReferences;
            this.Contents = contents;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Emails = emails;
            this.Environments = environments;
            this.Issues = issues;
            this.Keys = keys;
            this.Members = members;
            this.Metadata = metadata;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SecurityScanningAlert = securityScanningAlert;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhooksIssuePerformedViaGithubAppPermissions()
        {
        }

    }
}