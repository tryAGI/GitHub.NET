
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
    /// </summary>
    public enum AgentsCreateOrUpdateOrgSecretRequestVisibility
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCreateOrUpdateOrgSecretRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCreateOrUpdateOrgSecretRequestVisibility value)
        {
            return value switch
            {
                AgentsCreateOrUpdateOrgSecretRequestVisibility.All => "all",
                AgentsCreateOrUpdateOrgSecretRequestVisibility.Private => "private",
                AgentsCreateOrUpdateOrgSecretRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCreateOrUpdateOrgSecretRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => AgentsCreateOrUpdateOrgSecretRequestVisibility.All,
                "private" => AgentsCreateOrUpdateOrgSecretRequestVisibility.Private,
                "selected" => AgentsCreateOrUpdateOrgSecretRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}