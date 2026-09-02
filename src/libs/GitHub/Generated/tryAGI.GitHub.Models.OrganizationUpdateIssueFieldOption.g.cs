
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationUpdateIssueFieldOption
    {
        /// <summary>
        /// The id of an existing option to retain or update. Omit this when creating a new option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color for the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationUpdateIssueFieldOptionColorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrganizationUpdateIssueFieldOptionColor Color { get; set; }

        /// <summary>
        /// Priority of the option for ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateIssueFieldOption" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the option.
        /// </param>
        /// <param name="color">
        /// Color for the option.
        /// </param>
        /// <param name="priority">
        /// Priority of the option for ordering.
        /// </param>
        /// <param name="id">
        /// The id of an existing option to retain or update. Omit this when creating a new option.
        /// </param>
        /// <param name="description">
        /// Description of the option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUpdateIssueFieldOption(
            string name,
            global::tryAGI.GitHub.OrganizationUpdateIssueFieldOptionColor color,
            int priority,
            int? id,
            string? description)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdateIssueFieldOption" /> class.
        /// </summary>
        public OrganizationUpdateIssueFieldOption()
        {
        }

    }
}