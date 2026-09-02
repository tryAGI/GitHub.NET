
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem
    {
        /// <summary>
        ///
        /// </summary>
        NoAccessibleRepos,
        /// <summary>
        ///
        /// </summary>
        NoTextTerms,
        /// <summary>
        ///
        /// </summary>
        NonIssueTarget,
        /// <summary>
        ///
        /// </summary>
        OnlyNonSemanticFieldsRequested,
        /// <summary>
        ///
        /// </summary>
        OrBooleanNotSupported,
        /// <summary>
        ///
        /// </summary>
        QuotedText,
        /// <summary>
        ///
        /// </summary>
        ServerError,
        /// <summary>
        ///
        /// </summary>
        ServiceUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem value)
        {
            return value switch
            {
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NoAccessibleRepos => "no_accessible_repos",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NoTextTerms => "no_text_terms",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NonIssueTarget => "non_issue_target",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.OnlyNonSemanticFieldsRequested => "only_non_semantic_fields_requested",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.OrBooleanNotSupported => "or_boolean_not_supported",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.QuotedText => "quoted_text",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.ServerError => "server_error",
                SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.ServiceUnavailable => "service_unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem? ToEnum(string value)
        {
            return value switch
            {
                "no_accessible_repos" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NoAccessibleRepos,
                "no_text_terms" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NoTextTerms,
                "non_issue_target" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.NonIssueTarget,
                "only_non_semantic_fields_requested" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.OnlyNonSemanticFieldsRequested,
                "or_boolean_not_supported" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.OrBooleanNotSupported,
                "quoted_text" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.QuotedText,
                "server_error" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.ServerError,
                "service_unavailable" => SearchIssuesAndPullRequestsResponseLexicalFallbackReasonItem.ServiceUnavailable,
                _ => null,
            };
        }
    }
}