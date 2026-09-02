
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForUserRequestVariant2DataType
    {
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddFieldForUserRequestVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForUserRequestVariant2DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForUserRequestVariant2DataType.SingleSelect => "single_select",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForUserRequestVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "single_select" => ProjectsAddFieldForUserRequestVariant2DataType.SingleSelect,
                _ => null,
            };
        }
    }
}