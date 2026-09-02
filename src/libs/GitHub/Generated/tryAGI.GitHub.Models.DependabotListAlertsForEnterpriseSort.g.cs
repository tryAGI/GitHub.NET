
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum DependabotListAlertsForEnterpriseSort
    {
        /// <summary>
        ///
        /// </summary>
        Created,
        /// <summary>
        ///
        /// </summary>
        EpssPercentage,
        /// <summary>
        ///
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForEnterpriseSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForEnterpriseSort value)
        {
            return value switch
            {
                DependabotListAlertsForEnterpriseSort.Created => "created",
                DependabotListAlertsForEnterpriseSort.EpssPercentage => "epss_percentage",
                DependabotListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForEnterpriseSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => DependabotListAlertsForEnterpriseSort.Created,
                "epss_percentage" => DependabotListAlertsForEnterpriseSort.EpssPercentage,
                "updated" => DependabotListAlertsForEnterpriseSort.Updated,
                _ => null,
            };
        }
    }
}