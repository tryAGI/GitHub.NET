
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The campaign metadata and alert stats.
    /// </summary>
    public sealed partial class CampaignSummary
    {
        /// <summary>
        /// The number of the newly created campaign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The date and time the campaign was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the campaign was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The campaign name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The campaign description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The campaign managers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser> Managers { get; set; }

        /// <summary>
        /// The campaign team managers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_managers")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.Team>? TeamManagers { get; set; }

        /// <summary>
        /// The date and time the campaign was published, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        public global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// The date and time the campaign has ended, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndsAt { get; set; }

        /// <summary>
        /// The date and time the campaign was closed, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ. Will be null if the campaign is still open.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Indicates whether a campaign is open or closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CampaignStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CampaignState State { get; set; }

        /// <summary>
        /// The contact link of the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_link")]
        public string? ContactLink { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_stats")]
        public global::tryAGI.GitHub.CampaignSummaryAlertStats? AlertStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummary" /> class.
        /// </summary>
        /// <param name="number">
        /// The number of the newly created campaign
        /// </param>
        /// <param name="createdAt">
        /// The date and time the campaign was created, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the campaign was last updated, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="description">
        /// The campaign description
        /// </param>
        /// <param name="managers">
        /// The campaign managers
        /// </param>
        /// <param name="endsAt">
        /// The date and time the campaign has ended, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="state">
        /// Indicates whether a campaign is open or closed
        /// </param>
        /// <param name="name">
        /// The campaign name
        /// </param>
        /// <param name="teamManagers">
        /// The campaign team managers
        /// </param>
        /// <param name="publishedAt">
        /// The date and time the campaign was published, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="closedAt">
        /// The date and time the campaign was closed, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ. Will be null if the campaign is still open.
        /// </param>
        /// <param name="contactLink">
        /// The contact link of the campaign.
        /// </param>
        /// <param name="alertStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignSummary(
            int number,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string description,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser> managers,
            global::System.DateTime endsAt,
            global::tryAGI.GitHub.CampaignState state,
            string? name,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Team>? teamManagers,
            global::System.DateTime? publishedAt,
            global::System.DateTime? closedAt,
            string? contactLink,
            global::tryAGI.GitHub.CampaignSummaryAlertStats? alertStats)
        {
            this.Number = number;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Managers = managers ?? throw new global::System.ArgumentNullException(nameof(managers));
            this.TeamManagers = teamManagers;
            this.PublishedAt = publishedAt;
            this.EndsAt = endsAt;
            this.ClosedAt = closedAt;
            this.State = state;
            this.ContactLink = contactLink;
            this.AlertStats = alertStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummary" /> class.
        /// </summary>
        public CampaignSummary()
        {
        }

    }
}