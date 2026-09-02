
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Source answers the question, "where did this role come from?"
    /// </summary>
    public enum OrganizationRoleSource
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRoleSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleSource value)
        {
            return value switch
            {
                OrganizationRoleSource.Enterprise => "Enterprise",
                OrganizationRoleSource.Organization => "Organization",
                OrganizationRoleSource.Predefined => "Predefined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleSource? ToEnum(string value)
        {
            return value switch
            {
                "Enterprise" => OrganizationRoleSource.Enterprise,
                "Organization" => OrganizationRoleSource.Organization,
                "Predefined" => OrganizationRoleSource.Predefined,
                _ => null,
            };
        }
    }
}