#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search code<br/>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:<br/>
        /// `q=addClass+in:file+language:js+repo:jquery/jquery`<br/>
        /// This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.<br/>
        /// Considerations for code search:<br/>
        /// Due to the complexity of searching code, there are a few restrictions on how searches are performed:<br/>
        /// *   Only the _default branch_ is considered. In most cases, this will be the `master` branch.<br/>
        /// *   Only files smaller than 384 KB are searchable.<br/>
        /// *   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazing<br/>
        /// language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.<br/>
        /// This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SearchCodeResponse> SearchCodeAsync(
            string q,
            global::tryAGI.GitHub.SearchCodeSort? sort = default,
            global::tryAGI.GitHub.SearchCodeOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search code<br/>
        /// Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:<br/>
        /// `q=addClass+in:file+language:js+repo:jquery/jquery`<br/>
        /// This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.<br/>
        /// Considerations for code search:<br/>
        /// Due to the complexity of searching code, there are a few restrictions on how searches are performed:<br/>
        /// *   Only the _default branch_ is considered. In most cases, this will be the `master` branch.<br/>
        /// *   Only files smaller than 384 KB are searchable.<br/>
        /// *   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=language%3Ago&amp;type=Code) is not valid, while [`amazing<br/>
        /// language:go`](https://github.com/search?utf8=%E2%9C%93&amp;q=amazing+language%3Ago&amp;type=Code) is.<br/>
        /// This endpoint requires you to authenticate and limits you to 10 requests per minute.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SearchCodeResponse>> SearchCodeAsResponseAsync(
            string q,
            global::tryAGI.GitHub.SearchCodeSort? sort = default,
            global::tryAGI.GitHub.SearchCodeOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps SearchCodeAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.CodeSearchResultItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.CodeSearchResultItem> SearchCodeAutoPagingAsync(
            string q,             global::tryAGI.GitHub.SearchCodeSort? sort = default,
            global::tryAGI.GitHub.SearchCodeOrder? order = default,
            int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}