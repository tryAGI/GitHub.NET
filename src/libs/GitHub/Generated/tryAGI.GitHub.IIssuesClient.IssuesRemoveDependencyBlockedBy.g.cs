#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Remove dependency an issue is blocked by<br/>
        /// You can use the REST API to remove a dependency that an issue is blocked by.<br/>
        /// Removing content too quickly using this endpoint may result in secondary rate limiting.<br/>
        /// For more information, see [Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)<br/>
        /// and [Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).<br/>
        /// This endpoint supports the following custom media types. For more information, see [Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw Markdown body. Response will include `body`. This is the default if you do not pass a specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the Markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's Markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="issueId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Issue> IssuesRemoveDependencyBlockedByAsync(
            string owner,
            string repo,
            int issueNumber,
            int issueId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove dependency an issue is blocked by<br/>
        /// You can use the REST API to remove a dependency that an issue is blocked by.<br/>
        /// Removing content too quickly using this endpoint may result in secondary rate limiting.<br/>
        /// For more information, see [Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)<br/>
        /// and [Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).<br/>
        /// This endpoint supports the following custom media types. For more information, see [Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw Markdown body. Response will include `body`. This is the default if you do not pass a specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the Markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's Markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="issueId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Issue>> IssuesRemoveDependencyBlockedByAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,
            int issueId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}