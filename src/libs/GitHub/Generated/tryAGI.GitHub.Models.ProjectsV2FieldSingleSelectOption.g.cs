
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsV2FieldSingleSelectOption
    {
        /// <summary>
        /// The display name of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The color associated with the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsV2FieldSingleSelectOptionColorJsonConverter))]
        public global::tryAGI.GitHub.ProjectsV2FieldSingleSelectOptionColor? Color { get; set; }

        /// <summary>
        /// The description of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldSingleSelectOption" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name of the option.
        /// </param>
        /// <param name="color">
        /// The color associated with the option.
        /// </param>
        /// <param name="description">
        /// The description of the option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsV2FieldSingleSelectOption(
            string? name,
            global::tryAGI.GitHub.ProjectsV2FieldSingleSelectOptionColor? color,
            string? description)
        {
            this.Name = name;
            this.Color = color;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2FieldSingleSelectOption" /> class.
        /// </summary>
        public ProjectsV2FieldSingleSelectOption()
        {
        }

    }
}