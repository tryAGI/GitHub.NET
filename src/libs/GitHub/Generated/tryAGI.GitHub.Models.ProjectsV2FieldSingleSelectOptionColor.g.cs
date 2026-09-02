
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The color associated with the option.
    /// </summary>
    public enum ProjectsV2FieldSingleSelectOptionColor
    {
        /// <summary>
        ///
        /// </summary>
        Blue,
        /// <summary>
        ///
        /// </summary>
        Gray,
        /// <summary>
        ///
        /// </summary>
        Green,
        /// <summary>
        ///
        /// </summary>
        Orange,
        /// <summary>
        ///
        /// </summary>
        Pink,
        /// <summary>
        ///
        /// </summary>
        Purple,
        /// <summary>
        ///
        /// </summary>
        Red,
        /// <summary>
        ///
        /// </summary>
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2FieldSingleSelectOptionColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2FieldSingleSelectOptionColor value)
        {
            return value switch
            {
                ProjectsV2FieldSingleSelectOptionColor.Blue => "BLUE",
                ProjectsV2FieldSingleSelectOptionColor.Gray => "GRAY",
                ProjectsV2FieldSingleSelectOptionColor.Green => "GREEN",
                ProjectsV2FieldSingleSelectOptionColor.Orange => "ORANGE",
                ProjectsV2FieldSingleSelectOptionColor.Pink => "PINK",
                ProjectsV2FieldSingleSelectOptionColor.Purple => "PURPLE",
                ProjectsV2FieldSingleSelectOptionColor.Red => "RED",
                ProjectsV2FieldSingleSelectOptionColor.Yellow => "YELLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2FieldSingleSelectOptionColor? ToEnum(string value)
        {
            return value switch
            {
                "BLUE" => ProjectsV2FieldSingleSelectOptionColor.Blue,
                "GRAY" => ProjectsV2FieldSingleSelectOptionColor.Gray,
                "GREEN" => ProjectsV2FieldSingleSelectOptionColor.Green,
                "ORANGE" => ProjectsV2FieldSingleSelectOptionColor.Orange,
                "PINK" => ProjectsV2FieldSingleSelectOptionColor.Pink,
                "PURPLE" => ProjectsV2FieldSingleSelectOptionColor.Purple,
                "RED" => ProjectsV2FieldSingleSelectOptionColor.Red,
                "YELLOW" => ProjectsV2FieldSingleSelectOptionColor.Yellow,
                _ => null,
            };
        }
    }
}