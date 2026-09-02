
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnterpriseTeamsCreateRequest
    {
        /// <summary>
        /// The name of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be set.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsCreateRequestSyncToOrganizationsJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsCreateRequestSyncToOrganizations? SyncToOrganizations { get; set; }

        /// <summary>
        /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
        /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
        /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments) endpoint.<br/>
        /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_selection_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsCreateRequestOrganizationSelectionTypeJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsCreateRequestOrganizationSelectionType? OrganizationSelectionType { get; set; }

        /// <summary>
        /// The ID of the IdP group to assign team membership with. You can get this value from the [REST API endpoints for SCIM](https://docs.github.com/rest/scim#list-provisioned-scim-groups-for-an-enterprise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The notification setting the team is set to. The options are:<br/>
        /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
        /// * `notifications_disabled` - no one receives notifications.<br/>
        /// Default: `notifications_enabled`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsCreateRequestNotificationSettingJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsCreateRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// A description of the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be set.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="organizationSelectionType">
        /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
        /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
        /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments) endpoint.<br/>
        /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. You can get this value from the [REST API endpoints for SCIM](https://docs.github.com/rest/scim#list-provisioned-scim-groups-for-an-enterprise).
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team is set to. The options are:<br/>
        /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
        /// * `notifications_disabled` - no one receives notifications.<br/>
        /// Default: `notifications_enabled`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamsCreateRequest(
            string name,
            string? description,
            global::tryAGI.GitHub.EnterpriseTeamsCreateRequestSyncToOrganizations? syncToOrganizations,
            global::tryAGI.GitHub.EnterpriseTeamsCreateRequestOrganizationSelectionType? organizationSelectionType,
            string? groupId,
            global::tryAGI.GitHub.EnterpriseTeamsCreateRequestNotificationSetting? notificationSetting)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.SyncToOrganizations = syncToOrganizations;
            this.OrganizationSelectionType = organizationSelectionType;
            this.GroupId = groupId;
            this.NotificationSetting = notificationSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsCreateRequest" /> class.
        /// </summary>
        public EnterpriseTeamsCreateRequest()
        {
        }

    }
}