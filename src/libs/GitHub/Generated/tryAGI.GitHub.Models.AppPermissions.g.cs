
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The permissions granted to the fine-grained access token.<br/>
    /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
    /// </summary>
    public sealed partial class AppPermissions
    {
        /// <summary>
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsActionsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsAdministrationJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create and retrieve build artifact metadata records.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsArtifactMetadataJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsArtifactMetadata? ArtifactMetadata { get; set; }

        /// <summary>
        /// The level of permission to create and retrieve the access token for repository attestations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsAttestationsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsAttestations? Attestations { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for checks on code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsChecksJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage code quality data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsCodeQualityJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsCodeQuality? CodeQuality { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsCodespacesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsCodespaces? Codespaces { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsContentsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsDependabotSecretsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsDependabotSecrets? DependabotSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsDeploymentsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for discussions and related comments and labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsDiscussionsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing repository environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsEnvironmentsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsIssuesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the merge queues for a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_queues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsMergeQueuesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsMergeQueues? MergeQueues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsMetadataJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsPackagesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsPagesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsPullRequestsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsRepositoryCustomPropertiesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsRepositoryCustomProperties? RepositoryCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsRepositoryHooksJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsRepositoryProjectsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsSecretScanningAlertsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsSecretsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsSecurityEventsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage just a single file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsSingleFileJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for commit statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsStatusesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsWorkflowsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for an organization, when allowed by the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties_for_organizations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsCustomPropertiesForOrganizationsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsCustomPropertiesForOrganizations? CustomPropertiesForOrganizations { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization teams and members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsMembersJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage access to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationAdministrationJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom repository roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationCustomRolesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationCustomRoles? OrganizationCustomRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom organization roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_org_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationCustomOrgRolesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationCustomOrgRoles? OrganizationCustomOrgRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository custom properties management at the organization level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationCustomPropertiesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationCustomProperties? OrganizationCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in public preview and is subject to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_copilot_seat_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationCopilotSeatManagementJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationCopilotSeatManagement? OrganizationCopilotSeatManagement { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage Copilot cloud agent settings for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_copilot_agent_settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationCopilotAgentSettingsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationCopilotAgentSettings? OrganizationCopilotAgentSettings { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_announcement_banners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationAnnouncementBannersJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationAnnouncementBanners? OrganizationAnnouncementBanners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationEventsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationEvents? OrganizationEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationHooksJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationPersonalAccessTokensJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationPersonalAccessTokens? OrganizationPersonalAccessTokens { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_token_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationPersonalAccessTokenRequestsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationPersonalAccessTokenRequests? OrganizationPersonalAccessTokenRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationPlanJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization projects and projects public preview (where available).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationProjectsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationPackagesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationSecretsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_addresses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsEmailAddressesJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsEmailAddresses? EmailAddresses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsFollowersJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsFollowers? Followers { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_ssh_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsGitSshKeysJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsGitSshKeys? GitSshKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpg_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsGpgKeysJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsGpgKeys? GpgKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_limits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsInteractionLimitsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsInteractionLimits? InteractionLimits { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsProfileJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsProfile? Profile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsStarringJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsStarring? Starring { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization custom properties management at the enterprise level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_custom_properties_for_organizations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AppPermissionsEnterpriseCustomPropertiesForOrganizationsJsonConverter))]
        public global::tryAGI.GitHub.AppPermissionsEnterpriseCustomPropertiesForOrganizations? EnterpriseCustomPropertiesForOrganizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        /// <param name="actions">
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </param>
        /// <param name="administration">
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </param>
        /// <param name="artifactMetadata">
        /// The level of permission to grant the access token to create and retrieve build artifact metadata records.
        /// </param>
        /// <param name="attestations">
        /// The level of permission to create and retrieve the access token for repository attestations.
        /// </param>
        /// <param name="checks">
        /// The level of permission to grant the access token for checks on code.
        /// </param>
        /// <param name="codeQuality">
        /// The level of permission to grant the access token to view and manage code quality data.
        /// </param>
        /// <param name="codespaces">
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </param>
        /// <param name="contents">
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </param>
        /// <param name="dependabotSecrets">
        /// The level of permission to grant the access token to manage Dependabot secrets.
        /// </param>
        /// <param name="deployments">
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </param>
        /// <param name="discussions">
        /// The level of permission to grant the access token for discussions and related comments and labels.
        /// </param>
        /// <param name="environments">
        /// The level of permission to grant the access token for managing repository environments.
        /// </param>
        /// <param name="issues">
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </param>
        /// <param name="mergeQueues">
        /// The level of permission to grant the access token to manage the merge queues for a repository.
        /// </param>
        /// <param name="metadata">
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </param>
        /// <param name="packages">
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </param>
        /// <param name="pages">
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </param>
        /// <param name="pullRequests">
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </param>
        /// <param name="repositoryCustomProperties">
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </param>
        /// <param name="repositoryHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </param>
        /// <param name="repositoryProjects">
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </param>
        /// <param name="secretScanningAlerts">
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </param>
        /// <param name="secrets">
        /// The level of permission to grant the access token to manage repository secrets.
        /// </param>
        /// <param name="securityEvents">
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </param>
        /// <param name="singleFile">
        /// The level of permission to grant the access token to manage just a single file.
        /// </param>
        /// <param name="statuses">
        /// The level of permission to grant the access token for commit statuses.
        /// </param>
        /// <param name="vulnerabilityAlerts">
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </param>
        /// <param name="workflows">
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </param>
        /// <param name="customPropertiesForOrganizations">
        /// The level of permission to grant the access token to view and edit custom properties for an organization, when allowed by the property.
        /// </param>
        /// <param name="members">
        /// The level of permission to grant the access token for organization teams and members.
        /// </param>
        /// <param name="organizationAdministration">
        /// The level of permission to grant the access token to manage access to an organization.
        /// </param>
        /// <param name="organizationCustomRoles">
        /// The level of permission to grant the access token for custom repository roles management.
        /// </param>
        /// <param name="organizationCustomOrgRoles">
        /// The level of permission to grant the access token for custom organization roles management.
        /// </param>
        /// <param name="organizationCustomProperties">
        /// The level of permission to grant the access token for repository custom properties management at the organization level.
        /// </param>
        /// <param name="organizationCopilotSeatManagement">
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in public preview and is subject to change.
        /// </param>
        /// <param name="organizationCopilotAgentSettings">
        /// The level of permission to grant the access token to view and manage Copilot cloud agent settings for an organization.
        /// </param>
        /// <param name="organizationAnnouncementBanners">
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </param>
        /// <param name="organizationEvents">
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </param>
        /// <param name="organizationHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokens">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokenRequests">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </param>
        /// <param name="organizationPlan">
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </param>
        /// <param name="organizationProjects">
        /// The level of permission to grant the access token to manage organization projects and projects public preview (where available).
        /// </param>
        /// <param name="organizationPackages">
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </param>
        /// <param name="organizationSecrets">
        /// The level of permission to grant the access token to manage organization secrets.
        /// </param>
        /// <param name="organizationSelfHostedRunners">
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </param>
        /// <param name="organizationUserBlocking">
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </param>
        /// <param name="emailAddresses">
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </param>
        /// <param name="followers">
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </param>
        /// <param name="gitSshKeys">
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </param>
        /// <param name="gpgKeys">
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </param>
        /// <param name="interactionLimits">
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </param>
        /// <param name="profile">
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </param>
        /// <param name="starring">
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </param>
        /// <param name="enterpriseCustomPropertiesForOrganizations">
        /// The level of permission to grant the access token for organization custom properties management at the enterprise level.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPermissions(
            global::tryAGI.GitHub.AppPermissionsActions? actions,
            global::tryAGI.GitHub.AppPermissionsAdministration? administration,
            global::tryAGI.GitHub.AppPermissionsArtifactMetadata? artifactMetadata,
            global::tryAGI.GitHub.AppPermissionsAttestations? attestations,
            global::tryAGI.GitHub.AppPermissionsChecks? checks,
            global::tryAGI.GitHub.AppPermissionsCodeQuality? codeQuality,
            global::tryAGI.GitHub.AppPermissionsCodespaces? codespaces,
            global::tryAGI.GitHub.AppPermissionsContents? contents,
            global::tryAGI.GitHub.AppPermissionsDependabotSecrets? dependabotSecrets,
            global::tryAGI.GitHub.AppPermissionsDeployments? deployments,
            global::tryAGI.GitHub.AppPermissionsDiscussions? discussions,
            global::tryAGI.GitHub.AppPermissionsEnvironments? environments,
            global::tryAGI.GitHub.AppPermissionsIssues? issues,
            global::tryAGI.GitHub.AppPermissionsMergeQueues? mergeQueues,
            global::tryAGI.GitHub.AppPermissionsMetadata? metadata,
            global::tryAGI.GitHub.AppPermissionsPackages? packages,
            global::tryAGI.GitHub.AppPermissionsPages? pages,
            global::tryAGI.GitHub.AppPermissionsPullRequests? pullRequests,
            global::tryAGI.GitHub.AppPermissionsRepositoryCustomProperties? repositoryCustomProperties,
            global::tryAGI.GitHub.AppPermissionsRepositoryHooks? repositoryHooks,
            global::tryAGI.GitHub.AppPermissionsRepositoryProjects? repositoryProjects,
            global::tryAGI.GitHub.AppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::tryAGI.GitHub.AppPermissionsSecrets? secrets,
            global::tryAGI.GitHub.AppPermissionsSecurityEvents? securityEvents,
            global::tryAGI.GitHub.AppPermissionsSingleFile? singleFile,
            global::tryAGI.GitHub.AppPermissionsStatuses? statuses,
            global::tryAGI.GitHub.AppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::tryAGI.GitHub.AppPermissionsWorkflows? workflows,
            global::tryAGI.GitHub.AppPermissionsCustomPropertiesForOrganizations? customPropertiesForOrganizations,
            global::tryAGI.GitHub.AppPermissionsMembers? members,
            global::tryAGI.GitHub.AppPermissionsOrganizationAdministration? organizationAdministration,
            global::tryAGI.GitHub.AppPermissionsOrganizationCustomRoles? organizationCustomRoles,
            global::tryAGI.GitHub.AppPermissionsOrganizationCustomOrgRoles? organizationCustomOrgRoles,
            global::tryAGI.GitHub.AppPermissionsOrganizationCustomProperties? organizationCustomProperties,
            global::tryAGI.GitHub.AppPermissionsOrganizationCopilotSeatManagement? organizationCopilotSeatManagement,
            global::tryAGI.GitHub.AppPermissionsOrganizationCopilotAgentSettings? organizationCopilotAgentSettings,
            global::tryAGI.GitHub.AppPermissionsOrganizationAnnouncementBanners? organizationAnnouncementBanners,
            global::tryAGI.GitHub.AppPermissionsOrganizationEvents? organizationEvents,
            global::tryAGI.GitHub.AppPermissionsOrganizationHooks? organizationHooks,
            global::tryAGI.GitHub.AppPermissionsOrganizationPersonalAccessTokens? organizationPersonalAccessTokens,
            global::tryAGI.GitHub.AppPermissionsOrganizationPersonalAccessTokenRequests? organizationPersonalAccessTokenRequests,
            global::tryAGI.GitHub.AppPermissionsOrganizationPlan? organizationPlan,
            global::tryAGI.GitHub.AppPermissionsOrganizationProjects? organizationProjects,
            global::tryAGI.GitHub.AppPermissionsOrganizationPackages? organizationPackages,
            global::tryAGI.GitHub.AppPermissionsOrganizationSecrets? organizationSecrets,
            global::tryAGI.GitHub.AppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::tryAGI.GitHub.AppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::tryAGI.GitHub.AppPermissionsEmailAddresses? emailAddresses,
            global::tryAGI.GitHub.AppPermissionsFollowers? followers,
            global::tryAGI.GitHub.AppPermissionsGitSshKeys? gitSshKeys,
            global::tryAGI.GitHub.AppPermissionsGpgKeys? gpgKeys,
            global::tryAGI.GitHub.AppPermissionsInteractionLimits? interactionLimits,
            global::tryAGI.GitHub.AppPermissionsProfile? profile,
            global::tryAGI.GitHub.AppPermissionsStarring? starring,
            global::tryAGI.GitHub.AppPermissionsEnterpriseCustomPropertiesForOrganizations? enterpriseCustomPropertiesForOrganizations)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.ArtifactMetadata = artifactMetadata;
            this.Attestations = attestations;
            this.Checks = checks;
            this.CodeQuality = codeQuality;
            this.Codespaces = codespaces;
            this.Contents = contents;
            this.DependabotSecrets = dependabotSecrets;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Environments = environments;
            this.Issues = issues;
            this.MergeQueues = mergeQueues;
            this.Metadata = metadata;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryCustomProperties = repositoryCustomProperties;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
            this.CustomPropertiesForOrganizations = customPropertiesForOrganizations;
            this.Members = members;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationCustomRoles = organizationCustomRoles;
            this.OrganizationCustomOrgRoles = organizationCustomOrgRoles;
            this.OrganizationCustomProperties = organizationCustomProperties;
            this.OrganizationCopilotSeatManagement = organizationCopilotSeatManagement;
            this.OrganizationCopilotAgentSettings = organizationCopilotAgentSettings;
            this.OrganizationAnnouncementBanners = organizationAnnouncementBanners;
            this.OrganizationEvents = organizationEvents;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPersonalAccessTokens = organizationPersonalAccessTokens;
            this.OrganizationPersonalAccessTokenRequests = organizationPersonalAccessTokenRequests;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.EmailAddresses = emailAddresses;
            this.Followers = followers;
            this.GitSshKeys = gitSshKeys;
            this.GpgKeys = gpgKeys;
            this.InteractionLimits = interactionLimits;
            this.Profile = profile;
            this.Starring = starring;
            this.EnterpriseCustomPropertiesForOrganizations = enterpriseCustomPropertiesForOrganizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        public AppPermissions()
        {
        }

    }
}