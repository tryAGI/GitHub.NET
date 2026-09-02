#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search labels<br/>
        /// Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:<br/>
        /// `q=bug+defect+enhancement&amp;repository_id=64778136`<br/>
        /// The labels that best match the query appear first in the search results.
        /// </summary>
        /// <param name="repositoryId"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SearchLabelsResponse> SearchLabelsAsync(
            int repositoryId,
            string q,
            global::tryAGI.GitHub.SearchLabelsSort? sort = default,
            global::tryAGI.GitHub.SearchLabelsOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search labels<br/>
        /// Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:<br/>
        /// `q=bug+defect+enhancement&amp;repository_id=64778136`<br/>
        /// The labels that best match the query appear first in the search results.
        /// </summary>
        /// <param name="repositoryId"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SearchLabelsResponse>> SearchLabelsAsResponseAsync(
            int repositoryId,
            string q,
            global::tryAGI.GitHub.SearchLabelsSort? sort = default,
            global::tryAGI.GitHub.SearchLabelsOrder? order = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps SearchLabelsAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.LabelSearchResultItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="repositoryId"></param>
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
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.LabelSearchResultItem> SearchLabelsAutoPagingAsync(
            int repositoryId,
            string q,             global::tryAGI.GitHub.SearchLabelsSort? sort = default,
            global::tryAGI.GitHub.SearchLabelsOrder? order = default,
            int? perPage = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}