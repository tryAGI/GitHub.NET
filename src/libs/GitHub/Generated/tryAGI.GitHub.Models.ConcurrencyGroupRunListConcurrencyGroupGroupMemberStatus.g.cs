
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus
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
    public static class ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus value)
        {
            return value switch
            {
                ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus.InProgress => "in_progress",
                ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus.InProgress,
                "pending" => ConcurrencyGroupRunListConcurrencyGroupGroupMemberStatus.Pending,
                _ => null,
            };
        }
    }
}