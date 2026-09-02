
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestStackMinimalPullRequestState
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
    public static class PullRequestStackMinimalPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestStackMinimalPullRequestState value)
        {
            return value switch
            {
                PullRequestStackMinimalPullRequestState.Closed => "closed",
                PullRequestStackMinimalPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestStackMinimalPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => PullRequestStackMinimalPullRequestState.Closed,
                "open" => PullRequestStackMinimalPullRequestState.Open,
                _ => null,
            };
        }
    }
}