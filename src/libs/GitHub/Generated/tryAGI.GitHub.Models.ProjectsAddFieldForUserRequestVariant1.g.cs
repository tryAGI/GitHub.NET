
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsAddFieldForUserRequestVariant1
    {
        /// <summary>
        /// The name of the field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The field's data type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsAddFieldForUserRequestVariant1DataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant1DataType DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForUserRequestVariant1" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="dataType">
        /// The field's data type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAddFieldForUserRequestVariant1(
            string name,
            global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant1DataType dataType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForUserRequestVariant1" /> class.
        /// </summary>
        public ProjectsAddFieldForUserRequestVariant1()
        {
        }

    }
}