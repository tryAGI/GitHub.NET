
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PackagesListPackagesForAuthenticatedUserVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesListPackagesForAuthenticatedUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForAuthenticatedUserVisibility value)
        {
            return value switch
            {
                PackagesListPackagesForAuthenticatedUserVisibility.Internal => "internal",
                PackagesListPackagesForAuthenticatedUserVisibility.Private => "private",
                PackagesListPackagesForAuthenticatedUserVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForAuthenticatedUserVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => PackagesListPackagesForAuthenticatedUserVisibility.Internal,
                "private" => PackagesListPackagesForAuthenticatedUserVisibility.Private,
                "public" => PackagesListPackagesForAuthenticatedUserVisibility.Public,
                _ => null,
            };
        }
    }
}