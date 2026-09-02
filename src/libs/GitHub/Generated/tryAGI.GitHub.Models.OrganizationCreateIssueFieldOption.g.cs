
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationCreateIssueFieldOption
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrganizationCreateIssueFieldOptionColorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrganizationCreateIssueFieldOptionColor Color { get; set; }

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
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueFieldOption" /> class.
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
        /// <param name="description">
        /// Description of the option.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreateIssueFieldOption(
            string name,
            global::tryAGI.GitHub.OrganizationCreateIssueFieldOptionColor color,
            int priority,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreateIssueFieldOption" /> class.
        /// </summary>
        public OrganizationCreateIssueFieldOption()
        {
        }

    }
}