
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsUpdateInOrgRequest
    {
        /// <summary>
        /// The name of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.TeamsUpdateInOrgRequestPrivacyJsonConverter))]
        public global::tryAGI.GitHub.TeamsUpdateInOrgRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.TeamsUpdateInOrgRequestNotificationSettingJsonConverter))]
        public global::tryAGI.GitHub.TeamsUpdateInOrgRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Closing down notice**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.TeamsUpdateInOrgRequestPermissionJsonConverter))]
        public global::tryAGI.GitHub.TeamsUpdateInOrgRequestPermission? Permission { get; set; }

        /// <summary>
        /// The ID of a team to set as the parent team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_team_id")]
        public int? ParentTeamId { get; set; }

        /// <summary>
        /// The slug of a team to set as the parent team. Ignored when `parent_team_id` is also provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_team_slug")]
        public string? ParentTeamSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateInOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
        /// </param>
        /// <param name="permission">
        /// **Closing down notice**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </param>
        /// <param name="parentTeamId">
        /// The ID of a team to set as the parent team.
        /// </param>
        /// <param name="parentTeamSlug">
        /// The slug of a team to set as the parent team. Ignored when `parent_team_id` is also provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsUpdateInOrgRequest(
            string? name,
            string? description,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestPrivacy? privacy,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestNotificationSetting? notificationSetting,
            global::tryAGI.GitHub.TeamsUpdateInOrgRequestPermission? permission,
            int? parentTeamId,
            string? parentTeamSlug)
        {
            this.Name = name;
            this.Description = description;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Permission = permission;
            this.ParentTeamId = parentTeamId;
            this.ParentTeamSlug = parentTeamSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateInOrgRequest" /> class.
        /// </summary>
        public TeamsUpdateInOrgRequest()
        {
        }

    }
}