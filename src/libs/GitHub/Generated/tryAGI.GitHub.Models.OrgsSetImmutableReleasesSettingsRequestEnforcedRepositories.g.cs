
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy that controls how immutable releases are enforced in the organization.<br/>
    /// Example: all
    /// </summary>
    public enum OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories
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
    public static class OrgsSetImmutableReleasesSettingsRequestEnforcedRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories value)
        {
            return value switch
            {
                OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.All => "all",
                OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.None => "none",
                OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.All,
                "none" => OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.None,
                "selected" => OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories.Selected,
                _ => null,
            };
        }
    }
}