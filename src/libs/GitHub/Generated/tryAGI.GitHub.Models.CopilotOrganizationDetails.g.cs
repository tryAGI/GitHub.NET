
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Information about the seat breakdown and policies set for an organization with a Copilot Business or Copilot Enterprise subscription.
    /// </summary>
    public sealed partial class CopilotOrganizationDetails
    {
        /// <summary>
        /// The breakdown of Copilot Business seats for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotOrganizationSeatBreakdown SeatBreakdown { get; set; }

        /// <summary>
        /// The organization policy for allowing or blocking suggestions matching public code (duplication detection filter).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_code_suggestions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsPublicCodeSuggestionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotOrganizationDetailsPublicCodeSuggestions PublicCodeSuggestions { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot Chat in the IDE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ide_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsIdeChatJsonConverter))]
        public global::tryAGI.GitHub.CopilotOrganizationDetailsIdeChat? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot features on GitHub.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsPlatformChatJsonConverter))]
        public global::tryAGI.GitHub.CopilotOrganizationDetailsPlatformChat? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cli")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsCliJsonConverter))]
        public global::tryAGI.GitHub.CopilotOrganizationDetailsCli? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_management_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsSeatManagementSettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotOrganizationDetailsSeatManagementSetting SeatManagementSetting { get; set; }

        /// <summary>
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotOrganizationDetailsPlanTypeJsonConverter))]
        public global::tryAGI.GitHub.CopilotOrganizationDetailsPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotOrganizationDetails" /> class.
        /// </summary>
        /// <param name="seatBreakdown">
        /// The breakdown of Copilot Business seats for the organization.
        /// </param>
        /// <param name="publicCodeSuggestions">
        /// The organization policy for allowing or blocking suggestions matching public code (duplication detection filter).
        /// </param>
        /// <param name="seatManagementSetting">
        /// The mode of assigning new seats.
        /// </param>
        /// <param name="ideChat">
        /// The organization policy for allowing or disallowing Copilot Chat in the IDE.
        /// </param>
        /// <param name="platformChat">
        /// The organization policy for allowing or disallowing Copilot features on GitHub.com.
        /// </param>
        /// <param name="cli">
        /// The organization policy for allowing or disallowing Copilot CLI.
        /// </param>
        /// <param name="planType">
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotOrganizationDetails(
            global::tryAGI.GitHub.CopilotOrganizationSeatBreakdown seatBreakdown,
            global::tryAGI.GitHub.CopilotOrganizationDetailsPublicCodeSuggestions publicCodeSuggestions,
            global::tryAGI.GitHub.CopilotOrganizationDetailsSeatManagementSetting seatManagementSetting,
            global::tryAGI.GitHub.CopilotOrganizationDetailsIdeChat? ideChat,
            global::tryAGI.GitHub.CopilotOrganizationDetailsPlatformChat? platformChat,
            global::tryAGI.GitHub.CopilotOrganizationDetailsCli? cli,
            global::tryAGI.GitHub.CopilotOrganizationDetailsPlanType? planType)
        {
            this.SeatBreakdown = seatBreakdown ?? throw new global::System.ArgumentNullException(nameof(seatBreakdown));
            this.PublicCodeSuggestions = publicCodeSuggestions;
            this.IdeChat = ideChat;
            this.PlatformChat = platformChat;
            this.Cli = cli;
            this.SeatManagementSetting = seatManagementSetting;
            this.PlanType = planType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotOrganizationDetails" /> class.
        /// </summary>
        public CopilotOrganizationDetails()
        {
        }

    }
}