
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The current status.
    /// </summary>
    public enum NullableProjectsV2StatusUpdateStatus
    {
        /// <summary>
        ///
        /// </summary>
        AtRisk,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Inactive,
        /// <summary>
        ///
        /// </summary>
        OffTrack,
        /// <summary>
        ///
        /// </summary>
        OnTrack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableProjectsV2StatusUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableProjectsV2StatusUpdateStatus value)
        {
            return value switch
            {
                NullableProjectsV2StatusUpdateStatus.AtRisk => "AT_RISK",
                NullableProjectsV2StatusUpdateStatus.Complete => "COMPLETE",
                NullableProjectsV2StatusUpdateStatus.Inactive => "INACTIVE",
                NullableProjectsV2StatusUpdateStatus.OffTrack => "OFF_TRACK",
                NullableProjectsV2StatusUpdateStatus.OnTrack => "ON_TRACK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableProjectsV2StatusUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "AT_RISK" => NullableProjectsV2StatusUpdateStatus.AtRisk,
                "COMPLETE" => NullableProjectsV2StatusUpdateStatus.Complete,
                "INACTIVE" => NullableProjectsV2StatusUpdateStatus.Inactive,
                "OFF_TRACK" => NullableProjectsV2StatusUpdateStatus.OffTrack,
                "ON_TRACK" => NullableProjectsV2StatusUpdateStatus.OnTrack,
                _ => null,
            };
        }
    }
}