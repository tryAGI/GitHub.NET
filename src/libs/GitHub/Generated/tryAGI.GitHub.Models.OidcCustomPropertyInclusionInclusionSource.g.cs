
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether the inclusion was defined at the organization or enterprise level<br/>
    /// Example: organization
    /// </summary>
    public enum OidcCustomPropertyInclusionInclusionSource
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OidcCustomPropertyInclusionInclusionSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OidcCustomPropertyInclusionInclusionSource value)
        {
            return value switch
            {
                OidcCustomPropertyInclusionInclusionSource.Enterprise => "enterprise",
                OidcCustomPropertyInclusionInclusionSource.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OidcCustomPropertyInclusionInclusionSource? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OidcCustomPropertyInclusionInclusionSource.Enterprise,
                "organization" => OidcCustomPropertyInclusionInclusionSource.Organization,
                _ => null,
            };
        }
    }
}