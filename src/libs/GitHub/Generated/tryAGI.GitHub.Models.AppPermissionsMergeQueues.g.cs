
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token to manage the merge queues for a repository.
    /// </summary>
    public enum AppPermissionsMergeQueues
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
    public static class AppPermissionsMergeQueuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsMergeQueues value)
        {
            return value switch
            {
                AppPermissionsMergeQueues.Read => "read",
                AppPermissionsMergeQueues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsMergeQueues? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsMergeQueues.Read,
                "write" => AppPermissionsMergeQueues.Write,
                _ => null,
            };
        }
    }
}