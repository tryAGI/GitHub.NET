
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForUserRequestVariant1DataType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddFieldForUserRequestVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForUserRequestVariant1DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForUserRequestVariant1DataType.Date => "date",
                ProjectsAddFieldForUserRequestVariant1DataType.Number => "number",
                ProjectsAddFieldForUserRequestVariant1DataType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForUserRequestVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ProjectsAddFieldForUserRequestVariant1DataType.Date,
                "number" => ProjectsAddFieldForUserRequestVariant1DataType.Number,
                "text" => ProjectsAddFieldForUserRequestVariant1DataType.Text,
                _ => null,
            };
        }
    }
}