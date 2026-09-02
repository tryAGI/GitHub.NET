
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
    /// </summary>
    public enum AgentsCreateOrgVariableRequestVisibility
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
    public static class AgentsCreateOrgVariableRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCreateOrgVariableRequestVisibility value)
        {
            return value switch
            {
                AgentsCreateOrgVariableRequestVisibility.All => "all",
                AgentsCreateOrgVariableRequestVisibility.Private => "private",
                AgentsCreateOrgVariableRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCreateOrgVariableRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => AgentsCreateOrgVariableRequestVisibility.All,
                "private" => AgentsCreateOrgVariableRequestVisibility.Private,
                "selected" => AgentsCreateOrgVariableRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}