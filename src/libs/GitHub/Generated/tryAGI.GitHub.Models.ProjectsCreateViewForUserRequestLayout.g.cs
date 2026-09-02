
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The layout of the view.<br/>
    /// Example: board
    /// </summary>
    public enum ProjectsCreateViewForUserRequestLayout
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
    public static class ProjectsCreateViewForUserRequestLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateViewForUserRequestLayout value)
        {
            return value switch
            {
                ProjectsCreateViewForUserRequestLayout.Board => "board",
                ProjectsCreateViewForUserRequestLayout.Roadmap => "roadmap",
                ProjectsCreateViewForUserRequestLayout.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateViewForUserRequestLayout? ToEnum(string value)
        {
            return value switch
            {
                "board" => ProjectsCreateViewForUserRequestLayout.Board,
                "roadmap" => ProjectsCreateViewForUserRequestLayout.Roadmap,
                "table" => ProjectsCreateViewForUserRequestLayout.Table,
                _ => null,
            };
        }
    }
}