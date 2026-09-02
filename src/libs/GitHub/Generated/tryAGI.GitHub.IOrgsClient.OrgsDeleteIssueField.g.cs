#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete issue field for an organization<br/>
        /// Deletes an issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueFieldId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteIssueFieldAsync(
            string org,
            int issueFieldId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete issue field for an organization<br/>
        /// Deletes an issue field for an organization.<br/>
        /// You can find out more about issue fields in [Managing issue fields in an organization](https://docs.github.com/issues/tracking-your-work-with-issues/using-issues/managing-issue-fields-in-an-organization).<br/>
        /// To use this endpoint, the authenticated user must be an administrator for the organization. OAuth app tokens and<br/>
        /// personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="issueFieldId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> OrgsDeleteIssueFieldAsResponseAsync(
            string org,
            int issueFieldId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}