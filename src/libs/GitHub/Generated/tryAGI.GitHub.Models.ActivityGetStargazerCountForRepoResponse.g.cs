
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActivityGetStargazerCountForRepoResponse
    {
        /// <summary>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityGetStargazerCountForRepoResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityGetStargazerCountForRepoResponse(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityGetStargazerCountForRepoResponse" /> class.
        /// </summary>
        public ActivityGetStargazerCountForRepoResponse()
        {
        }

    }
}