
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsAddFieldForUserRequestVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsAddFieldForUserRequestVariant2DataTypeJsonConverter))]
        public global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant2DataType DataType { get; set; }

        /// <summary>
        /// The options available for single select fields. At least one option must be provided when creating a single select field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_select_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2FieldSingleSelectOption> SingleSelectOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForUserRequestVariant2" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the field.
        /// </param>
        /// <param name="singleSelectOptions">
        /// The options available for single select fields. At least one option must be provided when creating a single select field.
        /// </param>
        /// <param name="dataType">
        /// The field's data type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAddFieldForUserRequestVariant2(
            string name,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ProjectsV2FieldSingleSelectOption> singleSelectOptions,
            global::tryAGI.GitHub.ProjectsAddFieldForUserRequestVariant2DataType dataType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataType = dataType;
            this.SingleSelectOptions = singleSelectOptions ?? throw new global::System.ArgumentNullException(nameof(singleSelectOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForUserRequestVariant2" /> class.
        /// </summary>
        public ProjectsAddFieldForUserRequestVariant2()
        {
        }

    }
}