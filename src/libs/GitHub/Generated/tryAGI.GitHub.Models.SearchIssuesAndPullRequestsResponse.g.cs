
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchIssuesAndPullRequestsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncompleteResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueSearchResultItem> Items { get; set; }

        /// <summary>
        /// The type of search that was performed. Possible values are `lexical`, `semantic`, or `hybrid`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SearchIssuesAndPullRequestsResponseSearchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SearchIssuesAndPullRequestsResponseSearchType SearchType { get; set; }

        /// <summary>
        /// When a semantic or hybrid search falls back to lexical search, this field contains the reasons for the fallback. Only present when a fallback occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_fallback_reason")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem>? LexicalFallbackReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIssuesAndPullRequestsResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="incompleteResults"></param>
        /// <param name="items"></param>
        /// <param name="searchType">
        /// The type of search that was performed. Possible values are `lexical`, `semantic`, or `hybrid`.
        /// </param>
        /// <param name="lexicalFallbackReason">
        /// When a semantic or hybrid search falls back to lexical search, this field contains the reasons for the fallback. Only present when a fallback occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchIssuesAndPullRequestsResponse(
            int totalCount,
            bool incompleteResults,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueSearchResultItem> items,
            global::tryAGI.GitHub.SearchIssuesAndPullRequestsResponseSearchType searchType,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem>? lexicalFallbackReason)
        {
            this.TotalCount = totalCount;
            this.IncompleteResults = incompleteResults;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.SearchType = searchType;
            this.LexicalFallbackReason = lexicalFallbackReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIssuesAndPullRequestsResponse" /> class.
        /// </summary>
        public SearchIssuesAndPullRequestsResponse()
        {
        }

    }
}