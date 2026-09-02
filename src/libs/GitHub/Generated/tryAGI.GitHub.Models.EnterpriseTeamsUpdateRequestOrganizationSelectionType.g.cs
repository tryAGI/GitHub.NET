
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Specifies which organizations in the enterprise should have access to this team. Can be one of `disabled`, `selected`, or `all`.<br/>
    /// `disabled`: The team is not assigned to any organizations. This is the default when you create a new team.<br/>
    /// `selected`: The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments).<br/>
    /// `all`: The team is assigned to all current and future organizations in the enterprise.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum EnterpriseTeamsUpdateRequestOrganizationSelectionType
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
        /// The team is assigned to specific organizations. You can then use the [add organization assignments API](https://docs.github.com/rest/enterprise-teams/enterprise-team-organizations#add-organization-assignments).
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterpriseTeamsUpdateRequestOrganizationSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamsUpdateRequestOrganizationSelectionType value)
        {
            return value switch
            {
                EnterpriseTeamsUpdateRequestOrganizationSelectionType.All => "all",
                EnterpriseTeamsUpdateRequestOrganizationSelectionType.Disabled => "disabled",
                EnterpriseTeamsUpdateRequestOrganizationSelectionType.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamsUpdateRequestOrganizationSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "all" => EnterpriseTeamsUpdateRequestOrganizationSelectionType.All,
                "disabled" => EnterpriseTeamsUpdateRequestOrganizationSelectionType.Disabled,
                "selected" => EnterpriseTeamsUpdateRequestOrganizationSelectionType.Selected,
                _ => null,
            };
        }
    }
}