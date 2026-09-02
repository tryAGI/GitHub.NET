
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The visibility of the issue field. Can be `organization_members_only` (visible only within the organization) or `all` (visible to all users who can see issues).
    /// </summary>
    public enum IssueFieldVisibility
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
    public static class IssueFieldVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueFieldVisibility value)
        {
            return value switch
            {
                IssueFieldVisibility.All => "all",
                IssueFieldVisibility.OrganizationMembersOnly => "organization_members_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueFieldVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssueFieldVisibility.All,
                "organization_members_only" => IssueFieldVisibility.OrganizationMembersOnly,
                _ => null,
            };
        }
    }
}