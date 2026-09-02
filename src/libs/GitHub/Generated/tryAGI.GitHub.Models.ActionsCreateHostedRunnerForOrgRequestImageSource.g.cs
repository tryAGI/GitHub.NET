
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The source of the runner image.
    /// </summary>
    public enum ActionsCreateHostedRunnerForOrgRequestImageSource
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
    public static class ActionsCreateHostedRunnerForOrgRequestImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateHostedRunnerForOrgRequestImageSource value)
        {
            return value switch
            {
                ActionsCreateHostedRunnerForOrgRequestImageSource.Custom => "custom",
                ActionsCreateHostedRunnerForOrgRequestImageSource.Github => "github",
                ActionsCreateHostedRunnerForOrgRequestImageSource.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateHostedRunnerForOrgRequestImageSource? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ActionsCreateHostedRunnerForOrgRequestImageSource.Custom,
                "github" => ActionsCreateHostedRunnerForOrgRequestImageSource.Github,
                "partner" => ActionsCreateHostedRunnerForOrgRequestImageSource.Partner,
                _ => null,
            };
        }
    }
}