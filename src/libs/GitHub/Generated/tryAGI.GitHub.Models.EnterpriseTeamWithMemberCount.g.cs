
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Group of enterprise owners and/or members
    /// </summary>
    public sealed partial class EnterpriseTeamWithMemberCount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Retired: this field will not be returned with GHEC enterprise teams.<br/>
        /// Example: disabled
        /// </summary>
        /// <example>disabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        public string? SyncToOrganizations { get; set; }

        /// <summary>
        /// Example: selected
        /// </summary>
        /// <example>selected</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_selection_type")]
        public string? OrganizationSelectionType { get; set; }

        /// <summary>
        /// Example: 62ab9291-fae2-468e-974b-7e45096d5021
        /// </summary>
        /// <example>62ab9291-fae2-468e-974b-7e45096d5021</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Retired: this field will not be returned with GHEC enterprise teams.<br/>
        /// Example: Justice League
        /// </summary>
        /// <example>Justice League</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </summary>
        /// <example>https://github.com/enterprises/dc/teams/justice-league</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// The number of members in the enterprise team.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MembersCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether team members will receive notifications when the team is mentioned.<br/>
        /// Example: notifications_enabled
        /// </summary>
        /// <example>notifications_enabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.EnterpriseTeamWithMemberCountNotificationSettingJsonConverter))]
        public global::tryAGI.GitHub.EnterpriseTeamWithMemberCountNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamWithMemberCount" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="membersCount">
        /// The number of members in the enterprise team.<br/>
        /// Example: 3
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="syncToOrganizations">
        /// Retired: this field will not be returned with GHEC enterprise teams.<br/>
        /// Example: disabled
        /// </param>
        /// <param name="organizationSelectionType">
        /// Example: selected
        /// </param>
        /// <param name="groupId">
        /// Example: 62ab9291-fae2-468e-974b-7e45096d5021
        /// </param>
        /// <param name="groupName">
        /// Retired: this field will not be returned with GHEC enterprise teams.<br/>
        /// Example: Justice League
        /// </param>
        /// <param name="notificationSetting">
        /// Whether team members will receive notifications when the team is mentioned.<br/>
        /// Example: notifications_enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamWithMemberCount(
            long id,
            string name,
            string slug,
            string url,
            string htmlUrl,
            string membersUrl,
            int membersCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? syncToOrganizations,
            string? organizationSelectionType,
            string? groupId,
            string? groupName,
            global::tryAGI.GitHub.EnterpriseTeamWithMemberCountNotificationSetting? notificationSetting)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SyncToOrganizations = syncToOrganizations;
            this.OrganizationSelectionType = organizationSelectionType;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.MembersCount = membersCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NotificationSetting = notificationSetting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamWithMemberCount" /> class.
        /// </summary>
        public EnterpriseTeamWithMemberCount()
        {
        }

    }
}