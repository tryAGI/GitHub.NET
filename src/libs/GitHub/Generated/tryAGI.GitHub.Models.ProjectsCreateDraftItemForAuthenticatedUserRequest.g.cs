
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsCreateDraftItemForAuthenticatedUserRequest
    {
        /// <summary>
        /// The title of the draft issue item to create in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The body content of the draft issue item to create in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateDraftItemForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the draft issue item to create in the project.
        /// </param>
        /// <param name="body">
        /// The body content of the draft issue item to create in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateDraftItemForAuthenticatedUserRequest(
            string title,
            string? body)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateDraftItemForAuthenticatedUserRequest" /> class.
        /// </summary>
        public ProjectsCreateDraftItemForAuthenticatedUserRequest()
        {
        }

    }
}