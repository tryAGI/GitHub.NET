
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ConcurrencyGroupGroupMemberStatus
    {
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConcurrencyGroupGroupMemberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConcurrencyGroupGroupMemberStatus value)
        {
            return value switch
            {
                ConcurrencyGroupGroupMemberStatus.InProgress => "in_progress",
                ConcurrencyGroupGroupMemberStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConcurrencyGroupGroupMemberStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ConcurrencyGroupGroupMemberStatus.InProgress,
                "pending" => ConcurrencyGroupGroupMemberStatus.Pending,
                _ => null,
            };
        }
    }
}