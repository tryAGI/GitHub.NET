
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotGetCopilotCodingAgentPermissionsOrganizationResponse
    {
        /// <summary>
        /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// The URL for the selected repositories endpoint. Only present when `enabled_repositories` is `selected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCodingAgentPermissionsOrganizationResponse" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// The URL for the selected repositories endpoint. Only present when `enabled_repositories` is `selected`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotGetCopilotCodingAgentPermissionsOrganizationResponse(
            global::tryAGI.GitHub.CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories enabledRepositories,
            string? selectedRepositoriesUrl)
        {
            this.EnabledRepositories = enabledRepositories;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCodingAgentPermissionsOrganizationResponse" /> class.
        /// </summary>
        public CopilotGetCopilotCodingAgentPermissionsOrganizationResponse()
        {
        }

    }
}