
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The layout of the view.<br/>
    /// Example: board
    /// </summary>
    public enum ProjectsCreateViewForOrgRequestLayout
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
    public static class ProjectsCreateViewForOrgRequestLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsCreateViewForOrgRequestLayout value)
        {
            return value switch
            {
                ProjectsCreateViewForOrgRequestLayout.Board => "board",
                ProjectsCreateViewForOrgRequestLayout.Roadmap => "roadmap",
                ProjectsCreateViewForOrgRequestLayout.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsCreateViewForOrgRequestLayout? ToEnum(string value)
        {
            return value switch
            {
                "board" => ProjectsCreateViewForOrgRequestLayout.Board,
                "roadmap" => ProjectsCreateViewForOrgRequestLayout.Roadmap,
                "table" => ProjectsCreateViewForOrgRequestLayout.Table,
                _ => null,
            };
        }
    }
}