
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to create and retrieve the access token for repository attestations.
    /// </summary>
    public enum AppPermissionsAttestations
    {
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsAttestationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsAttestations value)
        {
            return value switch
            {
                AppPermissionsAttestations.Read => "read",
                AppPermissionsAttestations.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsAttestations? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsAttestations.Read,
                "write" => AppPermissionsAttestations.Write,
                _ => null,
            };
        }
    }
}