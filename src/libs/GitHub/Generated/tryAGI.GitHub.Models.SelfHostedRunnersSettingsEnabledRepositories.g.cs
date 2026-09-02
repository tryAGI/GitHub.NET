
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy that controls whether self-hosted runners can be used by repositories in the organization
    /// </summary>
    public enum SelfHostedRunnersSettingsEnabledRepositories
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelfHostedRunnersSettingsEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelfHostedRunnersSettingsEnabledRepositories value)
        {
            return value switch
            {
                SelfHostedRunnersSettingsEnabledRepositories.All => "all",
                SelfHostedRunnersSettingsEnabledRepositories.None => "none",
                SelfHostedRunnersSettingsEnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelfHostedRunnersSettingsEnabledRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => SelfHostedRunnersSettingsEnabledRepositories.All,
                "none" => SelfHostedRunnersSettingsEnabledRepositories.None,
                "selected" => SelfHostedRunnersSettingsEnabledRepositories.Selected,
                _ => null,
            };
        }
    }
}