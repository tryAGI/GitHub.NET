
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSetCopilotCodingAgentPermissionsOrganizationRequest
    {
        /// <summary>
        /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetCopilotCodingAgentPermissionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSetCopilotCodingAgentPermissionsOrganizationRequest(
            global::tryAGI.GitHub.CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories enabledRepositories)
        {
            this.EnabledRepositories = enabledRepositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetCopilotCodingAgentPermissionsOrganizationRequest" /> class.
        /// </summary>
        public CopilotSetCopilotCodingAgentPermissionsOrganizationRequest()
        {
        }

    }
}