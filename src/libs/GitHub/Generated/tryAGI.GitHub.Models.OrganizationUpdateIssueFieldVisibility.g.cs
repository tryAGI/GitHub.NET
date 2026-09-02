
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled.
    /// </summary>
    public enum OrganizationUpdateIssueFieldVisibility
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        OrganizationMembersOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationUpdateIssueFieldVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationUpdateIssueFieldVisibility value)
        {
            return value switch
            {
                OrganizationUpdateIssueFieldVisibility.All => "all",
                OrganizationUpdateIssueFieldVisibility.OrganizationMembersOnly => "organization_members_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationUpdateIssueFieldVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationUpdateIssueFieldVisibility.All,
                "organization_members_only" => OrganizationUpdateIssueFieldVisibility.OrganizationMembersOnly,
                _ => null,
            };
        }
    }
}