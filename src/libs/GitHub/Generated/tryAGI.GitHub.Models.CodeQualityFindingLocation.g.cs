
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Code quality file location
    /// </summary>
    public sealed partial class CodeQualityFindingLocation
    {
        /// <summary>
        /// The file path where the finding was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The line number where the finding starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The column number where the finding starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// The line number where the finding ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// The column number where the finding ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingLocation" /> class.
        /// </summary>
        /// <param name="path">
        /// The file path where the finding was detected.
        /// </param>
        /// <param name="startLine">
        /// The line number where the finding starts.
        /// </param>
        /// <param name="startColumn">
        /// The column number where the finding starts.
        /// </param>
        /// <param name="endLine">
        /// The line number where the finding ends.
        /// </param>
        /// <param name="endColumn">
        /// The column number where the finding ends.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualityFindingLocation(
            string path,
            int? startLine,
            int? startColumn,
            int? endLine,
            int? endColumn)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.StartColumn = startColumn;
            this.EndLine = endLine;
            this.EndColumn = endColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingLocation" /> class.
        /// </summary>
        public CodeQualityFindingLocation()
        {
        }

    }
}