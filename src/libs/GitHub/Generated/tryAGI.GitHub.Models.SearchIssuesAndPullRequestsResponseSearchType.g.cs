
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The type of search that was performed. Possible values are `lexical`, `semantic`, or `hybrid`.
    /// </summary>
    public enum SearchIssuesAndPullRequestsResponseSearchType
    {
        /// <summary>
        ///
        /// </summary>
        Hybrid,
        /// <summary>
        ///
        /// </summary>
        Lexical,
        /// <summary>
        ///
        /// </summary>
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIssuesAndPullRequestsResponseSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIssuesAndPullRequestsResponseSearchType value)
        {
            return value switch
            {
                SearchIssuesAndPullRequestsResponseSearchType.Hybrid => "hybrid",
                SearchIssuesAndPullRequestsResponseSearchType.Lexical => "lexical",
                SearchIssuesAndPullRequestsResponseSearchType.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsResponseSearchType? ToEnum(string value)
        {
            return value switch
            {
                "hybrid" => SearchIssuesAndPullRequestsResponseSearchType.Hybrid,
                "lexical" => SearchIssuesAndPullRequestsResponseSearchType.Lexical,
                "semantic" => SearchIssuesAndPullRequestsResponseSearchType.Semantic,
                _ => null,
            };
        }
    }
}