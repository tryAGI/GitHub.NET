
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnterpriseTeamsUpdateRequest
    {
        /// <summary>
        /// A new name for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new description for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsUpdateRequestSyncToOrganizationsJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? SyncToOrganizations { get; set; }

        /// <summary>
        /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
        /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
        /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments).<br/>
        /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_selection_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsUpdateRequestOrganizationSelectionTypeJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestOrganizationSelectionType? OrganizationSelectionType { get; set; }

        /// <summary>
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The notification setting the team is set to. The options are:<br/>
        /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
        /// * `notifications_disabled` - no one receives notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamsUpdateRequestNotificationSettingJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the team.
        /// </param>
        /// <param name="description">
        /// A new description for the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="organizationSelectionType">
        /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
        /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
        /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments).<br/>
        /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team is set to. The options are:<br/>
        /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
        /// * `notifications_disabled` - no one receives notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamsUpdateRequest(
            string? name,
            string? description,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? syncToOrganizations,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestOrganizationSelectionType? organizationSelectionType,
            string? groupId,
            global::tryAGI.GitHub.EnterpriseTeamsUpdateRequestNotificationSetting? notificationSetting)
        {
            this.Name = name;
            this.Description = description;
            this.SyncToOrganizations = syncToOrganizations;
            this.OrganizationSelectionType = organizationSelectionType;
            this.GroupId = groupId;
            this.NotificationSetting = notificationSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsUpdateRequest" /> class.
        /// </summary>
        public EnterpriseTeamsUpdateRequest()
        {
        }

    }
}