
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Custom property set payload
    /// </summary>
    public sealed partial class CustomPropertySetPayload
    {
        /// <summary>
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </summary>
        /// <example>single_select</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CustomPropertySetPayloadValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CustomPropertySetPayloadValueType ValueType { get; set; }

        /// <summary>
        /// Whether the property is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default value of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? DefaultValue { get; set; }

        /// <summary>
        /// Short description of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_values")]
        public global::System.Collections.Generic.IList<string>? AllowedValues { get; set; }

        /// <summary>
        /// Who can edit the values of the property<br/>
        /// Example: org_actors
        /// </summary>
        /// <example>org_actors</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("values_editable_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CustomPropertySetPayloadValuesEditableByJsonConverter))]
        public global::tryAGI.GitHub.CustomPropertySetPayloadValuesEditableBy? ValuesEditableBy { get; set; }

        /// <summary>
        /// Whether setting properties values is mandatory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_explicit_values")]
        public bool? RequireExplicitValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertySetPayload" /> class.
        /// </summary>
        /// <param name="valueType">
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </param>
        /// <param name="required">
        /// Whether the property is required.
        /// </param>
        /// <param name="defaultValue">
        /// Default value of the property
        /// </param>
        /// <param name="description">
        /// Short description of the property
        /// </param>
        /// <param name="allowedValues">
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </param>
        /// <param name="valuesEditableBy">
        /// Who can edit the values of the property<br/>
        /// Example: org_actors
        /// </param>
        /// <param name="requireExplicitValues">
        /// Whether setting properties values is mandatory
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomPropertySetPayload(
            global::tryAGI.GitHub.CustomPropertySetPayloadValueType valueType,
            bool? required,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<string>>? defaultValue,
            string? description,
            global::System.Collections.Generic.IList<string>? allowedValues,
            global::tryAGI.GitHub.CustomPropertySetPayloadValuesEditableBy? valuesEditableBy,
            bool? requireExplicitValues)
        {
            this.ValueType = valueType;
            this.Required = required;
            this.DefaultValue = defaultValue;
            this.Description = description;
            this.AllowedValues = allowedValues;
            this.ValuesEditableBy = valuesEditableBy;
            this.RequireExplicitValues = requireExplicitValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertySetPayload" /> class.
        /// </summary>
        public CustomPropertySetPayload()
        {
        }

    }
}