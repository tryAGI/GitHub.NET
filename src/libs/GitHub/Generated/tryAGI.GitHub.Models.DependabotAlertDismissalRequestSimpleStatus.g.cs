
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The current status of the dismissal request.
    /// </summary>
    public enum DependabotAlertDismissalRequestSimpleStatus
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertDismissalRequestSimpleStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertDismissalRequestSimpleStatus value)
        {
            return value switch
            {
                DependabotAlertDismissalRequestSimpleStatus.Approved => "approved",
                DependabotAlertDismissalRequestSimpleStatus.Cancelled => "cancelled",
                DependabotAlertDismissalRequestSimpleStatus.Pending => "pending",
                DependabotAlertDismissalRequestSimpleStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertDismissalRequestSimpleStatus? ToEnum(string value)
        {
            return value switch
            {
                "approved" => DependabotAlertDismissalRequestSimpleStatus.Approved,
                "cancelled" => DependabotAlertDismissalRequestSimpleStatus.Cancelled,
                "pending" => DependabotAlertDismissalRequestSimpleStatus.Pending,
                "rejected" => DependabotAlertDismissalRequestSimpleStatus.Rejected,
                _ => null,
            };
        }
    }
}