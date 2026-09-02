
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token for discussions and related comments and labels.
    /// </summary>
    public enum AppPermissionsDiscussions
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
    public static class AppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsDiscussions value)
        {
            return value switch
            {
                AppPermissionsDiscussions.Read => "read",
                AppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsDiscussions.Read,
                "write" => AppPermissionsDiscussions.Write,
                _ => null,
            };
        }
    }
}