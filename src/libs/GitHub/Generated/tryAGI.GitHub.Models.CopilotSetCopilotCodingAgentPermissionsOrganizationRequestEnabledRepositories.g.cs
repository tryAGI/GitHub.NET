
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
    /// </summary>
    public enum CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories value)
        {
            return value switch
            {
                CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.All => "all",
                CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.None => "none",
                CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.All,
                "none" => CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.None,
                "selected" => CopilotSetCopilotCodingAgentPermissionsOrganizationRequestEnabledRepositories.Selected,
                _ => null,
            };
        }
    }
}