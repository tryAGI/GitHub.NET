
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of the referenced issue.
    /// </summary>
    public sealed partial class NullableIssueReferenceIssueType
    {
        /// <summary>
        /// The unique identifier of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The node identifier of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The color of the issue type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueReferenceIssueType" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the issue type.
        /// </param>
        /// <param name="nodeId">
        /// The node identifier of the issue type.
        /// </param>
        /// <param name="name">
        /// The name of the issue type.
        /// </param>
        /// <param name="color">
        /// The color of the issue type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableIssueReferenceIssueType(
            int id,
            string nodeId,
            string name,
            string? color)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueReferenceIssueType" /> class.
        /// </summary>
        public NullableIssueReferenceIssueType()
        {
        }

    }
}