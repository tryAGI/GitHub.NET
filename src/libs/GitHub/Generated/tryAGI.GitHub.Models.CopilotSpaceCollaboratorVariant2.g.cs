
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSpaceCollaboratorVariant2
    {
        /// <summary>
        /// The collaborator actor type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceCollaboratorVariant2ActorTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2ActorType ActorType { get; set; }

        /// <summary>
        /// The role granted to the collaborator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceCollaboratorVariant2RoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2Role Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSpaceCollaboratorVariant2TypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public string? Privacy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        public string? NotificationSetting { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        public string? RepositoriesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public object? Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceCollaboratorVariant2" /> class.
        /// </summary>
        /// <param name="role">
        /// The role granted to the collaborator
        /// </param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="actorType">
        /// The collaborator actor type.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="membersUrl"></param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="organizationId"></param>
        /// <param name="parent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSpaceCollaboratorVariant2(
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2Role role,
            int id,
            string nodeId,
            string name,
            string slug,
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2ActorType actorType,
            global::tryAGI.GitHub.CopilotSpaceCollaboratorVariant2Type type,
            string? description,
            string? privacy,
            string? notificationSetting,
            string? url,
            string? htmlUrl,
            string? membersUrl,
            string? repositoriesUrl,
            int? organizationId,
            object? parent)
        {
            this.ActorType = actorType;
            this.Role = role;
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.Description = description;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.MembersUrl = membersUrl;
            this.RepositoriesUrl = repositoriesUrl;
            this.OrganizationId = organizationId;
            this.Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSpaceCollaboratorVariant2" /> class.
        /// </summary>
        public CopilotSpaceCollaboratorVariant2()
        {
        }

    }
}