
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Indicates whether a campaign is open or closed
    /// </summary>
    public enum CampaignState
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignState value)
        {
            return value switch
            {
                CampaignState.Closed => "closed",
                CampaignState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => CampaignState.Closed,
                "open" => CampaignState.Open,
                _ => null,
            };
        }
    }
}