
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues). Only used when the visibility settings feature is enabled. Defaults to `organization_members_only`.
    /// </summary>
    public enum OrganizationCreateIssueFieldVisibility
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
    public static class OrganizationCreateIssueFieldVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationCreateIssueFieldVisibility value)
        {
            return value switch
            {
                OrganizationCreateIssueFieldVisibility.All => "all",
                OrganizationCreateIssueFieldVisibility.OrganizationMembersOnly => "organization_members_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationCreateIssueFieldVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationCreateIssueFieldVisibility.All,
                "organization_members_only" => OrganizationCreateIssueFieldVisibility.OrganizationMembersOnly,
                _ => null,
            };
        }
    }
}