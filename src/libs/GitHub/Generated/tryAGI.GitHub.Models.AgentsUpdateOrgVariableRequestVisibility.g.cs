
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of repositories in the organization that can access the variable. `selected` means only the repositories specified by `selected_repository_ids` can access the variable.
    /// </summary>
    public enum AgentsUpdateOrgVariableRequestVisibility
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
    public static class AgentsUpdateOrgVariableRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsUpdateOrgVariableRequestVisibility value)
        {
            return value switch
            {
                AgentsUpdateOrgVariableRequestVisibility.All => "all",
                AgentsUpdateOrgVariableRequestVisibility.Private => "private",
                AgentsUpdateOrgVariableRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsUpdateOrgVariableRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => AgentsUpdateOrgVariableRequestVisibility.All,
                "private" => AgentsUpdateOrgVariableRequestVisibility.Private,
                "selected" => AgentsUpdateOrgVariableRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}