
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GistsCreateRequest
    {
        /// <summary>
        /// Description of the gist<br/>
        /// Example: Example Ruby script
        /// </summary>
        /// <example>Example Ruby script</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names and content for the files that make up the gist<br/>
        /// Example: {"hello.rb":{"content":"puts \u0022Hello, World!\u0022"}}
        /// </summary>
        /// <example>{"hello.rb":{"content":"puts \u0022Hello, World!\u0022"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::tryAGI.GitHub.GistsCreateRequestFiles2> Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<bool?, global::tryAGI.GitHub.GistsCreateRequestPublic?>))]
        public global::tryAGI.GitHub.OneOf<bool?, global::tryAGI.GitHub.GistsCreateRequestPublic?>? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Names and content for the files that make up the gist<br/>
        /// Example: {"hello.rb":{"content":"puts \u0022Hello, World!\u0022"}}
        /// </param>
        /// <param name="description">
        /// Description of the gist<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="public"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistsCreateRequest(
            global::System.Collections.Generic.Dictionary<string, global::tryAGI.GitHub.GistsCreateRequestFiles2> files,
            string? description,
            global::tryAGI.GitHub.OneOf<bool?, global::tryAGI.GitHub.GistsCreateRequestPublic?>? @public)
        {
            this.Description = description;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsCreateRequest" /> class.
        /// </summary>
        public GistsCreateRequest()
        {
        }

    }
}