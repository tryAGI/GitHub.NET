
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The image provider.
    /// </summary>
    public enum ActionsHostedRunnerCuratedImageSource
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Github,
        /// <summary>
        ///
        /// </summary>
        Partner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsHostedRunnerCuratedImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsHostedRunnerCuratedImageSource value)
        {
            return value switch
            {
                ActionsHostedRunnerCuratedImageSource.Custom => "custom",
                ActionsHostedRunnerCuratedImageSource.Github => "github",
                ActionsHostedRunnerCuratedImageSource.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsHostedRunnerCuratedImageSource? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ActionsHostedRunnerCuratedImageSource.Custom,
                "github" => ActionsHostedRunnerCuratedImageSource.Github,
                "partner" => ActionsHostedRunnerCuratedImageSource.Partner,
                _ => null,
            };
        }
    }
}