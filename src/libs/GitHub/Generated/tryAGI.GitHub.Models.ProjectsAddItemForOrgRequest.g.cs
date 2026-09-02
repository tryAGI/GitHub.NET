
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsAddItemForOrgRequest
    {
        /// <summary>
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ProjectsAddItemForOrgRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsAddItemForOrgRequestType Type { get; set; }

        /// <summary>
        /// The unique identifier of the issue or pull request to add to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The repository owner login.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// The repository name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// The issue or pull request number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddItemForOrgRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the issue or pull request to add to the project.
        /// </param>
        /// <param name="owner">
        /// The repository owner login.
        /// </param>
        /// <param name="repo">
        /// The repository name.
        /// </param>
        /// <param name="number">
        /// The issue or pull request number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAddItemForOrgRequest(
            global::tryAGI.GitHub.ProjectsAddItemForOrgRequestType type,
            int? id,
            string? owner,
            string? repo,
            int? number)
        {
            this.Type = type;
            this.Id = id;
            this.Owner = owner;
            this.Repo = repo;
            this.Number = number;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddItemForOrgRequest" /> class.
        /// </summary>
        public ProjectsAddItemForOrgRequest()
        {
        }

    }
}