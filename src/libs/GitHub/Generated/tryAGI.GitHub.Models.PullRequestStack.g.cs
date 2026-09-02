
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The stack information associated with a pull request.
    /// </summary>
    public sealed partial class PullRequestStack
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestStackBase Base { get; set; }

        /// <summary>
        /// The total number of pull requests in the stack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The one-based position of this pull request within the stack, where 1 is the bottom of the stack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// The ID of the stack that this pull request belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The number of the stack that this pull request belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStack" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="size">
        /// The total number of pull requests in the stack.
        /// </param>
        /// <param name="position">
        /// The one-based position of this pull request within the stack, where 1 is the bottom of the stack.
        /// </param>
        /// <param name="id">
        /// The ID of the stack that this pull request belongs to.
        /// </param>
        /// <param name="number">
        /// The number of the stack that this pull request belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStack(
            global::tryAGI.GitHub.PullRequestStackBase @base,
            int? size,
            int? position,
            int? id,
            int? number)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Size = size;
            this.Position = position;
            this.Id = id;
            this.Number = number;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStack" /> class.
        /// </summary>
        public PullRequestStack()
        {
        }

    }
}