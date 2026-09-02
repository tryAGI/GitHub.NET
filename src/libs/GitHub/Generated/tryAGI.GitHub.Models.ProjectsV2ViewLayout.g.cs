
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The layout of the view.
    /// </summary>
    public enum ProjectsV2ViewLayout
    {
        /// <summary>
        ///
        /// </summary>
        Board,
        /// <summary>
        ///
        /// </summary>
        Roadmap,
        /// <summary>
        ///
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2ViewLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2ViewLayout value)
        {
            return value switch
            {
                ProjectsV2ViewLayout.Board => "board",
                ProjectsV2ViewLayout.Roadmap => "roadmap",
                ProjectsV2ViewLayout.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2ViewLayout? ToEnum(string value)
        {
            return value switch
            {
                "board" => ProjectsV2ViewLayout.Board,
                "roadmap" => ProjectsV2ViewLayout.Roadmap,
                "table" => ProjectsV2ViewLayout.Table,
                _ => null,
            };
        }
    }
}