
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default repository access level for Dependabot updates.<br/>
    /// Example: internal
    /// </summary>
    public enum DependabotRepositoryAccessDetailsDefaultLevel
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
    public static class DependabotRepositoryAccessDetailsDefaultLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotRepositoryAccessDetailsDefaultLevel value)
        {
            return value switch
            {
                DependabotRepositoryAccessDetailsDefaultLevel.Internal => "internal",
                DependabotRepositoryAccessDetailsDefaultLevel.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotRepositoryAccessDetailsDefaultLevel? ToEnum(string value)
        {
            return value switch
            {
                "internal" => DependabotRepositoryAccessDetailsDefaultLevel.Internal,
                "public" => DependabotRepositoryAccessDetailsDefaultLevel.Public,
                _ => null,
            };
        }
    }
}