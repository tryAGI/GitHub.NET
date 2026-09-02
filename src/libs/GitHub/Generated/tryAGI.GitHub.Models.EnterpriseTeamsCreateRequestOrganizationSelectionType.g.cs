
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
    /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
    /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments) endpoint.<br/>
    /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum EnterpriseTeamsCreateRequestOrganizationSelectionType
    {
        /// <summary>
        /// The team is assigned to all current and future organizations in the enterprise.
        /// </summary>
        All,
        /// <summary>
        /// The team is not assigned to any organizations. This is the default when you create a new team.
        /// </summary>
        Disabled,
        /// <summary>
        /// The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments) endpoint.
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterpriseTeamsCreateRequestOrganizationSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamsCreateRequestOrganizationSelectionType value)
        {
            return value switch
            {
                EnterpriseTeamsCreateRequestOrganizationSelectionType.All => "all",
                EnterpriseTeamsCreateRequestOrganizationSelectionType.Disabled => "disabled",
                EnterpriseTeamsCreateRequestOrganizationSelectionType.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamsCreateRequestOrganizationSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "all" => EnterpriseTeamsCreateRequestOrganizationSelectionType.All,
                "disabled" => EnterpriseTeamsCreateRequestOrganizationSelectionType.Disabled,
                "selected" => EnterpriseTeamsCreateRequestOrganizationSelectionType.Selected,
                _ => null,
            };
        }
    }
}