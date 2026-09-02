
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The vulnerable dependency's relationship to your project.<br/>
    /// &gt; [!NOTE]<br/>
    /// &gt; We are rolling out support for dependency relationship across ecosystems. This value will be "unknown" for all dependencies in unsupported ecosystems.<br/>
    /// Included only in responses
    /// </summary>
    public enum DependabotAlertWithRepositoryDependencyRelationship
    {
        /// <summary>
        ///
        /// </summary>
        Direct,
        /// <summary>
        ///
        /// </summary>
        Inconclusive,
        /// <summary>
        ///
        /// </summary>
        Transitive,
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertWithRepositoryDependencyRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertWithRepositoryDependencyRelationship value)
        {
            return value switch
            {
                DependabotAlertWithRepositoryDependencyRelationship.Direct => "direct",
                DependabotAlertWithRepositoryDependencyRelationship.Inconclusive => "inconclusive",
                DependabotAlertWithRepositoryDependencyRelationship.Transitive => "transitive",
                DependabotAlertWithRepositoryDependencyRelationship.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertWithRepositoryDependencyRelationship? ToEnum(string value)
        {
            return value switch
            {
                "direct" => DependabotAlertWithRepositoryDependencyRelationship.Direct,
                "inconclusive" => DependabotAlertWithRepositoryDependencyRelationship.Inconclusive,
                "transitive" => DependabotAlertWithRepositoryDependencyRelationship.Transitive,
                "unknown" => DependabotAlertWithRepositoryDependencyRelationship.Unknown,
                _ => null,
            };
        }
    }
}