
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default repository access level for Dependabot updates.<br/>
    /// Example: internal
    /// </summary>
    public enum DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel value)
        {
            return value switch
            {
                DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel.Internal => "internal",
                DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel? ToEnum(string value)
        {
            return value switch
            {
                "internal" => DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel.Internal,
                "public" => DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel.Public,
                _ => null,
            };
        }
    }
}