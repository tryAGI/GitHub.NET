
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default repository access level for Dependabot updates.<br/>
    /// Example: internal
    /// </summary>
    public enum DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel
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
    public static class DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel value)
        {
            return value switch
            {
                DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel.Internal => "internal",
                DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel? ToEnum(string value)
        {
            return value switch
            {
                "internal" => DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel.Internal,
                "public" => DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel.Public,
                _ => null,
            };
        }
    }
}