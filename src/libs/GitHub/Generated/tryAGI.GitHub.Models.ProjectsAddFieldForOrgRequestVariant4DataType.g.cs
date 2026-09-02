
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsAddFieldForOrgRequestVariant4DataType
    {
        /// <summary>
        ///
        /// </summary>
        Iteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddFieldForOrgRequestVariant4DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddFieldForOrgRequestVariant4DataType value)
        {
            return value switch
            {
                ProjectsAddFieldForOrgRequestVariant4DataType.Iteration => "iteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddFieldForOrgRequestVariant4DataType? ToEnum(string value)
        {
            return value switch
            {
                "iteration" => ProjectsAddFieldForOrgRequestVariant4DataType.Iteration,
                _ => null,
            };
        }
    }
}