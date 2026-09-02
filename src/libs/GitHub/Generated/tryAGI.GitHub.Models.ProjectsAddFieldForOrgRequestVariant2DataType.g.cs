
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForOrgRequestVariant2DataType
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
    public static class ProjectsAddFieldForOrgRequestVariant2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForOrgRequestVariant2DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForOrgRequestVariant2DataType.Date => "date",
                ProjectsAddFieldForOrgRequestVariant2DataType.Number => "number",
                ProjectsAddFieldForOrgRequestVariant2DataType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForOrgRequestVariant2DataType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ProjectsAddFieldForOrgRequestVariant2DataType.Date,
                "number" => ProjectsAddFieldForOrgRequestVariant2DataType.Number,
                "text" => ProjectsAddFieldForOrgRequestVariant2DataType.Text,
                _ => null,
            };
        }
    }
}