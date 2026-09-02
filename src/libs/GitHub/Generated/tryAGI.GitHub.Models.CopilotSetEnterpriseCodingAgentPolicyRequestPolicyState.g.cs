
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy state for Copilot cloud agent in the enterprise. Can be one of `enabled_for_all_orgs`, `disabled_for_all_orgs`, `enabled_for_selected_orgs`, or `configured_by_org_admins`.
    /// </summary>
    public enum CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState
    {
        /// <summary>
        ///
        /// </summary>
        ConfiguredByOrgAdmins,
        /// <summary>
        ///
        /// </summary>
        DisabledForAllOrgs,
        /// <summary>
        ///
        /// </summary>
        EnabledForAllOrgs,
        /// <summary>
        ///
        /// </summary>
        EnabledForSelectedOrgs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSetEnterpriseCodingAgentPolicyRequestPolicyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState value)
        {
            return value switch
            {
                CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.ConfiguredByOrgAdmins => "configured_by_org_admins",
                CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.DisabledForAllOrgs => "disabled_for_all_orgs",
                CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.EnabledForAllOrgs => "enabled_for_all_orgs",
                CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.EnabledForSelectedOrgs => "enabled_for_selected_orgs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState? ToEnum(string value)
        {
            return value switch
            {
                "configured_by_org_admins" => CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.ConfiguredByOrgAdmins,
                "disabled_for_all_orgs" => CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.DisabledForAllOrgs,
                "enabled_for_all_orgs" => CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.EnabledForAllOrgs,
                "enabled_for_selected_orgs" => CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState.EnabledForSelectedOrgs,
                _ => null,
            };
        }
    }
}