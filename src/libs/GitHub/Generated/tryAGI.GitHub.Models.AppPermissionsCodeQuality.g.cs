
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage code quality data.
    /// </summary>
    public enum AppPermissionsCodeQuality
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
    public static class AppPermissionsCodeQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsCodeQuality value)
        {
            return value switch
            {
                AppPermissionsCodeQuality.Read => "read",
                AppPermissionsCodeQuality.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsCodeQuality? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsCodeQuality.Read,
                "write" => AppPermissionsCodeQuality.Write,
                _ => null,
            };
        }
    }
}