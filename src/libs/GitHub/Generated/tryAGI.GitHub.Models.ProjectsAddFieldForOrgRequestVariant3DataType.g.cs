
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForOrgRequestVariant3DataType
    {
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddFieldForOrgRequestVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForOrgRequestVariant3DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForOrgRequestVariant3DataType.SingleSelect => "single_select",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForOrgRequestVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "single_select" => ProjectsAddFieldForOrgRequestVariant3DataType.SingleSelect,
                _ => null,
            };
        }
    }
}