
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The policy that controls how immutable releases are enforced in the organization.<br/>
    /// Example: all
    /// </summary>
    public enum ImmutableReleasesOrganizationSettingsEnforcedRepositories
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
    public static class ImmutableReleasesOrganizationSettingsEnforcedRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImmutableReleasesOrganizationSettingsEnforcedRepositories value)
        {
            return value switch
            {
                ImmutableReleasesOrganizationSettingsEnforcedRepositories.All => "all",
                ImmutableReleasesOrganizationSettingsEnforcedRepositories.None => "none",
                ImmutableReleasesOrganizationSettingsEnforcedRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImmutableReleasesOrganizationSettingsEnforcedRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => ImmutableReleasesOrganizationSettingsEnforcedRepositories.All,
                "none" => ImmutableReleasesOrganizationSettingsEnforcedRepositories.None,
                "selected" => ImmutableReleasesOrganizationSettingsEnforcedRepositories.Selected,
                _ => null,
            };
        }
    }
}