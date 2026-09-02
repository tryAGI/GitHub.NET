#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Add issue field values to an issue<br/>
        /// Add custom field values to an issue. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// Adding an empty array will clear all existing field values for the issue.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// Only users with push access to the repository can add issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>> IssuesAddIssueFieldValuesAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.IssuesAddIssueFieldValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add issue field values to an issue<br/>
        /// Add custom field values to an issue. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// Adding an empty array will clear all existing field values for the issue.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// Only users with push access to the repository can add issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>>> IssuesAddIssueFieldValuesAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.IssuesAddIssueFieldValuesRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add issue field values to an issue<br/>
        /// Add custom field values to an issue. You can set values for organization-level issue fields that have been defined for the repository's organization.<br/>
        /// Adding an empty array will clear all existing field values for the issue.<br/>
        /// This endpoint supports the following field data types:<br/>
        /// - **`text`**: String values for text fields<br/>
        /// - **`single_select`**: Option names for single-select fields (must match an existing option name)<br/>
        /// - **`number`**: Numeric values for number fields<br/>
        /// - **`date`**: ISO 8601 date strings for date fields<br/>
        /// Only users with push access to the repository can add issue field values. If you don't have the proper permissions, you'll receive a `403 Forbidden` response.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"<br/>
        /// and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="issueFieldValues">
        /// An array of issue field values to add to this issue. Each field value must include the field ID and the value to set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueFieldValue>> IssuesAddIssueFieldValuesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesAddIssueFieldValuesRequestIssueFieldValue>? issueFieldValues = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}