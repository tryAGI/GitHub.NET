
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The changes to the team if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookTeamEditedChanges
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::tryAGI.GitHub.WebhookTeamEditedChangesDescription? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::tryAGI.GitHub.WebhookTeamEditedChangesName? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::tryAGI.GitHub.WebhookTeamEditedChangesPrivacy? Privacy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        public global::tryAGI.GitHub.WebhookTeamEditedChangesNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.WebhookTeamEditedChangesRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="repository"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEditedChanges(
            global::tryAGI.GitHub.WebhookTeamEditedChangesDescription? description,
            global::tryAGI.GitHub.WebhookTeamEditedChangesName? name,
            global::tryAGI.GitHub.WebhookTeamEditedChangesPrivacy? privacy,
            global::tryAGI.GitHub.WebhookTeamEditedChangesNotificationSetting? notificationSetting,
            global::tryAGI.GitHub.WebhookTeamEditedChangesRepository? repository)
        {
            this.Description = description;
            this.Name = name;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        public WebhookTeamEditedChanges()
        {
        }

    }
}