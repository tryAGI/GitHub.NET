
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssueFieldOption
    {
        /// <summary>
        /// The unique identifier of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The color of the option.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssueFieldOptionColorJsonConverter))]
        public global::tryAGI.GitHub.IssueFieldOptionColor? Color { get; set; }

        /// <summary>
        /// The priority of the option for ordering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The time the option was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time the option was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldOption" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the option.
        /// </param>
        /// <param name="name">
        /// The name of the option.
        /// </param>
        /// <param name="description">
        /// The description of the option.
        /// </param>
        /// <param name="color">
        /// The color of the option.
        /// </param>
        /// <param name="priority">
        /// The priority of the option for ordering.
        /// </param>
        /// <param name="createdAt">
        /// The time the option was created.
        /// </param>
        /// <param name="updatedAt">
        /// The time the option was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueFieldOption(
            int id,
            string name,
            string? description,
            global::tryAGI.GitHub.IssueFieldOptionColor? color,
            int? priority,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
            this.Priority = priority;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldOption" /> class.
        /// </summary>
        public IssueFieldOption()
        {
        }

    }
}