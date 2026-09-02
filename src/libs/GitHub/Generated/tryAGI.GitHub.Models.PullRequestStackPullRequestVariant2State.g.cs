
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestStackPullRequestVariant2State
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
    public static class PullRequestStackPullRequestVariant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestStackPullRequestVariant2State value)
        {
            return value switch
            {
                PullRequestStackPullRequestVariant2State.Closed => "closed",
                PullRequestStackPullRequestVariant2State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestStackPullRequestVariant2State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => PullRequestStackPullRequestVariant2State.Closed,
                "open" => PullRequestStackPullRequestVariant2State.Open,
                _ => null,
            };
        }
    }
}