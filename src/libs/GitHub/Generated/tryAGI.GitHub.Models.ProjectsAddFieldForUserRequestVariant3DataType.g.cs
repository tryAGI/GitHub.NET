
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForUserRequestVariant3DataType
    {
        /// <summary>
        ///
        /// </summary>
        Iteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddFieldForUserRequestVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForUserRequestVariant3DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForUserRequestVariant3DataType.Iteration => "iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForUserRequestVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "iteration" => ProjectsAddFieldForUserRequestVariant3DataType.Iteration,
                _ => null,
            };
        }
    }
}