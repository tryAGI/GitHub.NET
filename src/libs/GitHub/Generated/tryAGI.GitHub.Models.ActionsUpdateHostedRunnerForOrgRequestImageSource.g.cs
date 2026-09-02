
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The source type of the runner image to use. Must match the source of the image specified by `image_id`. Can be one of `github`, `partner`, or `custom`.
    /// </summary>
    public enum ActionsUpdateHostedRunnerForOrgRequestImageSource
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
    public static class ActionsUpdateHostedRunnerForOrgRequestImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateHostedRunnerForOrgRequestImageSource value)
        {
            return value switch
            {
                ActionsUpdateHostedRunnerForOrgRequestImageSource.Custom => "custom",
                ActionsUpdateHostedRunnerForOrgRequestImageSource.Github => "github",
                ActionsUpdateHostedRunnerForOrgRequestImageSource.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateHostedRunnerForOrgRequestImageSource? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ActionsUpdateHostedRunnerForOrgRequestImageSource.Custom,
                "github" => ActionsUpdateHostedRunnerForOrgRequestImageSource.Github,
                "partner" => ActionsUpdateHostedRunnerForOrgRequestImageSource.Partner,
                _ => null,
            };
        }
    }
}