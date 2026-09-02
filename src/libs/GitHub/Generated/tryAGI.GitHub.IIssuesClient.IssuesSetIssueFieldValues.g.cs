#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Set issue field values for an issue<br/>
        /// Set custom field values for an issue, replacing any existing values. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// This operation will replace all existing field values with the provided ones. If you want to add field values without replacing existing ones, use the `POST` endpoint instead.<br/>
        /// Only users with push access to the repository can set issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>> IssuesSetIssueFieldValuesAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.IssuesSetIssueFieldValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set issue field values for an issue<br/>
        /// Set custom field values for an issue, replacing any existing values. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// This operation will replace all existing field values with the provided ones. If you want to add field values without replacing existing ones, use the `POST` endpoint instead.<br/>
        /// Only users with push access to the repository can set issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>>> IssuesSetIssueFieldValuesAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.IssuesSetIssueFieldValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set issue field values for an issue<br/>
        /// Set custom field values for an issue, replacing any existing values. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// This operation will replace all existing field values with the provided ones. If you want to add field values without replacing existing ones, use the `POST` endpoint instead.<br/>
        /// Only users with push access to the repository can set issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="issueFieldValues">
        /// An array of issue field values to set for this issue. Each field value must include the field ID and the value to set. All existing field values will be replaced.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>> IssuesSetIssueFieldValuesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesSetIssueFieldValuesRequestIssueFieldValue>? issueFieldValues = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}