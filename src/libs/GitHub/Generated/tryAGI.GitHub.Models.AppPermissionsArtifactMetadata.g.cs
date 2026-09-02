
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level of permission to grant the access token to create and retrieve build artifact metadata records.
    /// </summary>
    public enum AppPermissionsArtifactMetadata
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
    public static class AppPermissionsArtifactMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsArtifactMetadata value)
        {
            return value switch
            {
                AppPermissionsArtifactMetadata.Read => "read",
                AppPermissionsArtifactMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsArtifactMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsArtifactMetadata.Read,
                "write" => AppPermissionsArtifactMetadata.Write,
                _ => null,
            };
        }
    }
}