
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy for which repositories can use Copilot cloud agent. Can be one of `all`, `selected`, or `none`.
    /// </summary>
    public enum CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories
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
    public static class CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories value)
        {
            return value switch
            {
                CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.All => "all",
                CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.None => "none",
                CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.All,
                "none" => CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.None,
                "selected" => CopilotGetCopilotCodingAgentPermissionsOrganizationResponseEnabledRepositories.Selected,
                _ => null,
            };
        }
    }
}